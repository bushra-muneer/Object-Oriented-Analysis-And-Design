using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.Controller
{
    class loginController
    {

        login log = new login();
        
        public void Regesteration(TextBox name,TextBox password,TextBox email,TextBox contect,ComboBox type)
        {

            if (name.Text!="" && password.Text!=""&&email.Text!=""&& contect.Text!=""&&type.Text!="")
            {
                log.email = email.Text.ToString();

                var check =log.Verify(log.email);

                if (check == true)
                {
                    log.name = name.Text.ToString();
                    log.password = password.Text.ToString();
                    log.email = email.Text.ToString();
                    log.contact = contect.Text.ToString();
                    log.type = type.Text.ToString();
                    log.Regester(log);
                    MessageBox.Show("Succesfully Regesterd");

                    name.Text = "";
                    password.Text = "";
                    email.Text = "";
                    contect.Text = "";
                    Form1 f = new Form1();
                    f.Show();
                    new Regester().Hide();
                   

                }
                else
                {
                    MessageBox.Show("Email is already regesterd");
                
                }

            }
            else 
            {
                MessageBox.Show("Fill this Form Completely");
            }
        
        
        }

        setting s = new setting();
        public void Verification(TextBox name, TextBox password, TextBox email)

        {

            if (name.Text != "" && password.Text != "" && email.Text != "")
            {
                log.name = name.Text.ToString();
                log.password = password.Text.ToString();
                log.email = email.Text.ToString();

              var check=  log.Verify(log.name,log.password,log.email);
                if (check == true)
                {
                    if (login.customertype == "ADMIN")
                    {
                        new Form1().Hide();

                        new ViewCustomer().Show();

                       
                    }
                    else
                    {
                        s.AddCustomerrid(login.customerid);
                        new Form1().Hide();
                        new PlaceOrder().Show();

                        


                    }

                }
                else
                {
                    MessageBox.Show("Enter Valid account information");
                
                }
            }
            else
            {

                MessageBox.Show("Enter Correctyl");
            
            }



        }




    }
}
