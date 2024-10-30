using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Documents;
using System.ComponentModel;

namespace UvDemo
{
    public class SpectrometerSettingsModel : XMLBaseObject
    {
        public enum TriggerModes
        {
            Internal,
            External,
            Software
        }


        [Category("Spec"), Description("Sets the number of scans to average. Typically set to 3."), DisplayName("Scans to Average")]
        public int ScansToAverage { get; set; }

        [Category("Spec"), Description("Pixel width of boxcar."), DisplayName("Boxcar Width")]
        public int BoxcarWidth { get; set; }

        [Category("Spec"), Description("Spectrometer integration time in μs."), DisplayName("Integration Time")]
        public int IntegrationTime { get; set; }

        [Category("Spec"), Description("Pixel width of boxcar."), DisplayName("Electric Dark")]
        public bool ElectricDark { get; set; }

        [Category("Spec"), Description("Set if the non-linearity correction should be used when taking a measurement."), DisplayName("Non-Linearity Correction")]
        public bool NonLinearityCorrection { get; set; }

        [Category("Spec"), Description("Trigger mode for the spectrometer. Usually set to Software."), DisplayName("Trigger Mode")]
        public TriggerModes TriggerMode { get; set; }

        [Category("Spec"), Description("Distance on the X-axis in nm."), DisplayName("X-Axis")]
        public float XAxis { get; set; }

        [Category("Spec"), Description("Sets whether the lamp is enabled."), DisplayName("Lamp Enabled")]
        public bool LampEnabled { get; set; }

        [Category("Spec"), Description("FixedPatternNoiseSubtractionEnabled desc."), DisplayName("Fixed Pattern Noise Subtraction Enabled ")]
        public bool FixedPatternNoiseSubtractionEnabled { get; set; }

        [Category("Spec"), Description("FixedPatternNoiseSubtractionReference desc."), DisplayName("Fixed Pattern Noise Subtraction Reference")]
        public string FixedPatternNoiseSubtractionReference { get; set; }



    }
}
