using Apple_Battery_Check.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_Battery_Check
{
    public class BatteryPack
    {
        private string[] _veri;

        public BatteryPack()
        {
            _veri = new string[40]; // Varsayılan değerlerle diziyi oluşturabilirsiniz
        }

        public void UpdateData(string gelenVeri)
        {
            _veri = gelenVeri.Split(Settings.Default.SEPARATOR_SLASH);
            VerileriIsle();
        }

        public double TemperatureKelvin { get; private set; }
        public double TemperatureCelsius { get; private set; }
        public double TemperatureFahrenheit { get; private set; }
        public double Voltage { get; private set; }
        public Int32 RemainingCapacity { get; private set; }
        public Int32 FullChargeCapacity { get; private set; }
        public string CycleCount { get; private set; }
        public string StateOfCharge { get; private set; }
        public string StateOfHealth { get; private set; }
        public string DesignCapacity { get; private set; }

        public string ControlStatus { get; private set; }
        public string DeviceType { get; private set; }
        public string FirmwareVersion { get; private set; }
        public string HardwareVersion { get; private set; }

        public string ManufacturerBlockA { get; private set; }
        public string ManufacturerBlockB { get; private set; }
        public string ManufacturerBlockC { get; private set; }
        public string Checksum { get; private set; }

        private void VerileriIsle()
        {
            TemperatureKelvin = Convert.ToDouble(_veri[2]) * Settings.Default.DECIMAL_FACTOR;
            TemperatureCelsius = TemperatureKelvin - Settings.Default.CELSIUS_OFFSET;
            TemperatureFahrenheit = TemperatureCelsius * 1.8 + 32;

            Voltage = Convert.ToDouble(_veri[3]);
            RemainingCapacity = Convert.ToInt32(_veri[6]);
            FullChargeCapacity = Convert.ToInt32(_veri[7]);

            CycleCount = _veri[18];
            StateOfCharge = _veri[19];
            StateOfHealth = _veri[21].Insert(2, Settings.Default.SEPARATOR_DOT);
            DesignCapacity = _veri[27];

            ControlStatus = "0x" + _veri[31].ToUpper();
            DeviceType = Resources.PREFIX_CONTROLLER + _veri[32].ToUpper();
            FirmwareVersion = _veri[33].Insert(1, Settings.Default.SEPARATOR_DOT);
            HardwareVersion = Convert.ToInt32(_veri[34].ToUpper(), 16).ToString().Insert(1, Settings.Default.SEPARATOR_DOT);

            ManufacturerBlockA = _veri[36];//bu bloklar null terminated döner uzunluklar sabit değildir
            ManufacturerBlockB = _veri[37];
            ManufacturerBlockC = _veri[38];
            //Checksum = _veri[39];
        }
    }

}
