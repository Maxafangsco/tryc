using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamPrep
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        
        }

        private void generate_car_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Mileage = 12000;
            car1.LicencePlateNumber = "QWEr 123";
            car1.BaseCost = 175;

            Car car2 = new Car();
            car2.Mileage = 1200;
            car2.LicencePlateNumber = "wphd 083";
            car2.BaseCost = 2875;

            Car car3 = new Car();
            car3.Mileage = 5000;
            car3.LicencePlateNumber = "tasj 923";
            car3.BaseCost = 165;

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);


            DisplayDetails(cars);

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Car selectedCar = (Car)list_number_plate.SelectedItem;

            if (selectedCar != null)
            {
                textBox1.Text = selectedCar.LicencePlateNumber;
                textBox2.Text = selectedCar.Mileage.ToString(); // Assuming Mileage is an integer property
                textBox3.Text = selectedCar.BaseCost.ToString(); // Assuming BaseCost is an integer property
            }
            else
            {
                textBox1.Text = ""; // Set the text to an empty string or handle it according to your requirements.
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }



        private void DisplayDetails(List<Car> car)
        {
         

            if (car != null)
            {

                foreach (Car Item in cars)
                {

                    list_number_plate.Items.Add(Item);
                }


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

            else
            {
                list_number_plate.Text = " ";
            }

        }

        private void delete_car_button_Click(object sender, EventArgs e)
        {
        
                if (list_number_plate.SelectedIndex != -1)
            {
               
                // cars.RemoveAt(list_number_plate.SelectedIndex);
                int index = list_number_plate.SelectedIndex;
                list_number_plate.Items.RemoveAt(index);

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Select an Item to delete");
            }
        }

        private void add_new_car_Click(object sender, EventArgs e)
        {

            if(textBox1.Text != " " && textBox2.Text != " " && textBox3.Text != " ")
            {
                Car mycar = new Car();


                mycar.LicencePlateNumber = textBox1.Text;
                mycar.Mileage = Convert.ToInt32(textBox2.Text);
                mycar.BaseCost = Convert.ToInt32(textBox3.Text);
                // cars.Add(mycar);
                list_number_plate.Items.Add((Car)mycar);


                textBox1.Text = ""; // Set the text to an empty string or handle it according to your requirements.
                textBox2.Text = "";
                textBox3.Text = "";

            }
            else
            {
                MessageBox.Show("You must fill all inputs");
            }
          
            
        }
    }

}