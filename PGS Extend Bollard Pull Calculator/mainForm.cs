using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            loadData();
        }

        #region Variables

        int shipLenght;
        float freeBoard;
        float containHeight;
        int windSpeed;
        int windBearing;
        float windageArea;
        int numberOfTugs;
        double bollardPull;
        double forcePer1000;
        List<Ship> shipList = new List<Ship>();
        string FilePath = Application.StartupPath;

        #endregion
        #region XML classes

        public class Ship
        {
            [XmlElement("ShipName")]
            public string shipName
            { get; set; }
            [XmlElement("ShipLength")]
            public int shipLength
            { get; set; }
        }

        #endregion
        #region Form Interaction

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInput() == true)
            {
                takeInputs();
                windageArea = shipLenght * (freeBoard + containHeight);
                forcePer1000 = (Math.Pow(windSpeedCalc(windBearing - 99, windSpeed), 2)) / 18;
                bollardPull = (forcePer1000 / 1000) * windageArea;
                bollardPull = Math.Round(bollardPull, 1);

                if (windBearing >= 009 && windBearing <= 189)
                {
                    bollardPull = 0;
                }

                sendOutputs();

                Console.WriteLine("Ship Lenght: " + shipLenght + "Metres");
                Console.WriteLine("Freeboard Height: " + freeBoard + "Metres");
                Console.WriteLine("Wind Speed: " + windSpeed + "Knots");
                Console.WriteLine("Windage Area: " + windageArea + "Metres Squarded");
                Console.WriteLine("Force Per 1000m^2: " + forcePer1000 + "Newtons");
                Console.WriteLine("Bollard Pull: " + bollardPull + "Newtons");
                Console.WriteLine("Number of Tugs: " + numberOfTugs);
            }
            else
            {
                MessageBox.Show("One or More of the Text Box's is either empty or doesn't contain only numbers, please check and try again");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }

        private void genertateNewShipxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateXML();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int thing = cBoxShipChoose.SelectedIndex;
            Console.WriteLine(thing);
            updateData();
        }

        private void reloadShipxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cBoxShipChoose.Items.Clear();
            loadData();
        }

        #endregion
        #region Methods

        void takeInputs()
        {
            shipLenght = Int32.Parse(tBoxShipLength.Text);
            freeBoard = float.Parse(tBoxFreebroad.Text);
            containHeight = float.Parse(tBoxContainerHeight.Text);
            windSpeed = Int32.Parse(textBox3.Text);
            windBearing = Int32.Parse(tBoxWindBearing.Text);
            numberOfTugs = Int32.Parse(tBoxNumberOfTugs.Text);
        }

        void sendOutputs()
        {
            label1.Text = "Windage Area: " + windageArea.ToString() + " m²";
            label2.Text = "Total Bollard Pull: " + bollardPull.ToString() + " Tons";
            label3.Text = "Bollard Pull per Tug: " + (bollardPull / numberOfTugs).ToString() + " Tons";
        }

        double windSpeedCalc(int bearing, int windSpeed)
        {
            double test = Math.PI / 180;
            Console.WriteLine(test);
            double test1 = test * (bearing + 180);
            Console.WriteLine(test1);
            double v = windSpeed * Math.Cos(test1);
            Console.WriteLine(v);
            return (v / 2);
        }

        bool checkInput()
        {
            List<TextBox> textBoxs = new List<TextBox> {tBoxContainerHeight, tBoxFreebroad, tBoxNumberOfTugs, tBoxShipLength, tBoxWindBearing };
            foreach (TextBox i in textBoxs)
            {
                if (checkForNum(i.Text) == false)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("String OK");
                }
            }
            return true;
        }

        bool checkForNum(string i)
        {
                double Num;
                bool isNum = double.TryParse(i.Trim(), out Num);
                return isNum;
        }

        void generateXML()
        {
            Ship ship = new Ship();
            ship.shipName = "Agulhas Stream";
            ship.shipLength = 150;

            Ship ship1 = new Ship();
            ship1.shipName = "Timor Stream";
            ship1.shipLength = 150;

            Ship ship2 = new Ship();
            ship2.shipName = "Klipper Stream";
            ship2.shipLength = 150;

            Ship ship3 = new Ship();
            ship3.shipName = "Star Best";
            ship3.shipLength = 163;

            Ship ship4 = new Ship();
            ship4.shipName = "Star Stratos";
            ship4.shipLength = 163;

            Ship ship5 = new Ship();
            ship5.shipName = "Crown Ruby";
            ship5.shipLength = 152;

            Ship ship6 = new Ship();
            ship6.shipName = "Crown Emerald";
            ship6.shipLength = 152;

            Ship ship7 = new Ship();
            ship7.shipName = "Crown Opal";
            ship7.shipLength = 152;

            List<Ship> ships = new List<Ship>() { ship, ship1, ship2, ship3, ship4, ship5, ship6, ship7 };

            SerializeToXML(ships);
        }

        static public void SerializeToXML(List<Ship> ship)
        {
            string FilePath = Application.StartupPath;
            XmlSerializer Serializer = new XmlSerializer(typeof(List<Ship>));
            TextWriter textWriter = new StreamWriter(FilePath + "\\Ship.xml");
            Serializer.Serialize(textWriter, ship);
            textWriter.Close();
            Console.WriteLine("Serialization Complete");
        }

        static List<Ship> DeserializeFromXml()
        {
            string FilePath = Application.StartupPath;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Ship>));
            TextReader textReader = new StreamReader(FilePath + "\\Ship.xml");
            List<Ship> ships;
            ships = (List<Ship>)deserializer.Deserialize(textReader);
            textReader.Close();
            return ships;
        }
        
        void updateData()
        {
            tBoxShipLength.Text = shipList[cBoxShipChoose.SelectedIndex].shipLength.ToString();
        }

        void checkShipStore()
        {
            string FilePath = Application.StartupPath;
            Console.WriteLine(FilePath);
            if (System.IO.File.Exists(FilePath + "\\Ship.xml") == false)
            {
                Console.WriteLine("No Ship.XML found. Generating New File...");
                generateXML();
                Console.WriteLine("XML File Generation Complete.");
            }
            else
            {
                Console.WriteLine("File exists, Continuing with Startup.");
            }
        }

        public void loadData()
        {
            checkShipStore();
            #region Xml Load
            shipList = DeserializeFromXml();
            int i = 0;
            foreach (Ship ship in shipList)
            {
                Console.WriteLine(shipList[i].shipName);
                Console.WriteLine(shipList[i].shipLength);
                i++;
            }
            #endregion
            #region cBox Load
            int n = 0;
            foreach (Ship ship in shipList)
            {
                cBoxShipChoose.Items.Add(shipList[n].shipName);
                n++;
                int thing = cBoxShipChoose.SelectedIndex;
            }
            #endregion
        }

        #endregion
    }
}
