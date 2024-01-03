using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHB3
{
    public partial class BotForm : Form
    {

        public bool refill;
        public bool lower;
        public bool increase;

        public BotForm()
        {
            InitializeComponent();
            this.Show();
            loadSettings();
        }

        public void loadSettings()
        {
            String fileName = Path.Combine(Directory.GetCurrentDirectory(), "bot.json");
            if (File.Exists(fileName))
            {
                BotSettings saved = JsonConvert.DeserializeObject<BotSettings>(File.ReadAllText(@fileName));
                this.checkBox1.Checked = saved.reffilOrder;
                this.checkBox2.Checked = saved.lowerPrice;
                this.checkBox3.Checked = saved.increasePrice;

                this.HighestPrice.Text = saved.HighestPrice.ToString();
                this.LowestPrice.Text = saved.LowestPrice.ToString();

                this.IncreaseStepMultiple.Text = saved.IncreaseStepMultiple.ToString();
                this.LowerStepMultiple.Text = saved.LowerStepMultiple.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = Path.Combine(Directory.GetCurrentDirectory(), "bot.json");
            BotSettings current = formSettings();
            File.WriteAllText(fileName, JsonConvert.SerializeObject(current));
            this.Close();
        }

        private BotSettings formSettings()
        {
            BotSettings current = new BotSettings();

            current.reffilOrder = false;
            current.lowerPrice = false;
            current.increasePrice = false;

            if (this.checkBox1.Checked) current.reffilOrder = true;
            if (this.checkBox2.Checked) current.lowerPrice = true;
            if (this.checkBox3.Checked) current.increasePrice = true;

            current.HighestPrice = float.Parse(this.HighestPrice.Text);
            current.LowestPrice = float.Parse(this.LowestPrice.Text);

            current.IncreaseStepMultiple = float.Parse(this.IncreaseStepMultiple.Text);
            current.LowerStepMultiple = float.Parse(this.LowerStepMultiple.Text);

            return current;
        }

        public class BotSettings
        {
            public bool reffilOrder { get; set; }

            public bool lowerPrice { get; set; }

            public bool increasePrice { get; set; }

            public float HighestPrice { get; set; }

            public float LowestPrice { get; set; }

            public float IncreaseStepMultiple { get; set; }

            public float LowerStepMultiple { get; set; }
        }
    }
}