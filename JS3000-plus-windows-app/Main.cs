namespace JS3000_plus_windows_app
{
    public partial class Main : Form
    {
        private int _deviceHandle;

        public Main()
        {
            InitializeComponent();
            FormClosing += Main_FormClosing;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtPort.Text = "5005";
            txtMachineNumber.Text = "1";
            txtPassword.Text = "0";
            txtLicense.Text = "1263";
            txtTimeOut.Text = "5000";
            chkUseUdp.Checked = false;
            SetConnectionUi(false);
            SetStatus("Enter the device settings, then connect.", Color.DimGray);
        }

        private bool IsDeviceConnected => _deviceHandle > 0;

        private void SetConnectionUi(bool connected)
        {
            btnConnect.Enabled = !connected;
            btnReadTime.Enabled = connected;
            btnDisconnect.Enabled = connected;
        }

        private void SetStatus(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
        }

        private static string DescribeResult(int resultCode)
        {
            return resultCode switch
            {
                1 => "Successful",
                0 => "Device does not support this operation",
                -2 => "Communication is not open",
                -3 => "Unable to write to the device",
                -4 => "Unable to read from the device",
                -5 => "Invalid device setting or parameter",
                -10 => "Incorrect network password or license",
                _ => $"SDK error {resultCode}"
            };
        }

        private int ConnectDevice(
            string ipAddress,
            int port,
            int machineNumber,
            int timeout,
            int networkPassword,
            int license,
            bool useUdp = false)
        {
            DisconnectDevice();

            _deviceHandle = BiometricSdk.FK_ConnectNet(
                machineNumber,
                ipAddress,
                port,
                timeout,
                useUdp ? BiometricSdk.ProtocolUdp : BiometricSdk.ProtocolTcp,
                networkPassword,
                license);

            return _deviceHandle;
        }

        private bool TryGetDeviceTime(out DateTime deviceTime, out int resultCode)
        {
            deviceTime = DateTime.MinValue;
            resultCode = 0;

            if (!IsDeviceConnected)
            {
                return false;
            }

            resultCode = BiometricSdk.FK_GetDeviceTime(_deviceHandle, ref deviceTime);
            return resultCode == BiometricSdk.Success;
        }

        private void DisconnectDevice()
        {
            if (!IsDeviceConnected)
            {
                return;
            }

            BiometricSdk.FK_DisConnect(_deviceHandle);
            _deviceHandle = 0;
        }

        private void Main_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DisconnectDevice();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIpAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                SetStatus("Enter the device IP address.", Color.Firebrick);
                txtIpAddress.Focus();
                return;
            }

            if (!int.TryParse(txtPort.Text, out int port) || port is < 1 or > 65535)
            {
                SetStatus("Enter a valid port number.", Color.Firebrick);
                txtPort.Focus();
                return;
            }

            if (!int.TryParse(txtMachineNumber.Text, out int machineNumber) || machineNumber < 1)
            {
                SetStatus("Enter a valid machine number.", Color.Firebrick);
                txtMachineNumber.Focus();
                return;
            }

            if (!int.TryParse(txtPassword.Text, out int networkPassword) || networkPassword < 0)
            {
                SetStatus("Enter a valid network password.", Color.Firebrick);
                txtPassword.Focus();
                return;
            }

            if (!int.TryParse(txtLicense.Text, out int license) || license < 0)
            {
                SetStatus("Enter a valid SDK license.", Color.Firebrick);
                txtLicense.Focus();
                return;
            }

            if (!int.TryParse(txtTimeOut.Text, out int timeout) || timeout < 1)
            {
                SetStatus("Enter a valid timeout in milliseconds.", Color.Firebrick);
                txtTimeOut.Focus();
                return;
            }

            try
            {
                SetStatus("Connecting...", Color.DarkGoldenrod);
                int result = ConnectDevice(
                    ipAddress,
                    port,
                    machineNumber,
                    timeout,
                    networkPassword,
                    license,
                    chkUseUdp.Checked);

                if (result > 0)
                {
                    SetConnectionUi(true);
                    SetStatus("Connected", Color.ForestGreen);
                    return;
                }

                SetConnectionUi(false);
                SetStatus($"Connection failed: {DescribeResult(result)}", Color.Firebrick);
            }
            catch (DllNotFoundException)
            {
                SetStatus("FKAttend.dll or one of its dependencies was not found.", Color.Firebrick);
            }
            catch (BadImageFormatException)
            {
                SetStatus("SDK architecture mismatch. Build and run as x86.", Color.Firebrick);
            }
            catch (Exception exception)
            {
                SetStatus($"Connection error: {exception.Message}", Color.Firebrick);
            }
        }

        private void btnReadTime_Click(object sender, EventArgs e)
        {
            if (TryGetDeviceTime(out DateTime deviceTime, out int resultCode))
            {
                SetStatus($"Device time: {deviceTime:yyyy-MM-dd HH:mm:ss}", Color.ForestGreen);
                return;
            }

            int lastError = IsDeviceConnected
                ? BiometricSdk.FK_GetLastError(_deviceHandle)
                : resultCode;

            SetStatus($"Unable to read time: {DescribeResult(lastError)}", Color.Firebrick);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectDevice();
            SetConnectionUi(false);
            SetStatus("Disconnected", Color.DimGray);
        }
    }
}
