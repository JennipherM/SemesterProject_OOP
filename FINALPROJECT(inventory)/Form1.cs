using System.Security.Cryptography;
using System.Text;

namespace FINALPROJECT_inventory_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* For Login Page / Form              

        username = usernameTB.Trim();
        password = passwordTB.Trim();

        if (string.IsEmptyOrWhiteSpace(username) || string.IsEmptyOrWhiteSpace(password))
        {
            print "Enter all fields";
            return;
        }

        password = encryptPassword(password);

        SqlActions userLogin = new SqlActions();

        //check if user exists
        if (userLogin.checkExisting(username))  //does exist
        {
            //check if password matches DB password
            bool pwrdMatch = userLogin.checkPassword(username, password);

            if (pwrdMatch)
            {
                //closes form1 (login form)
                this.Hide();

                //creates form2 obj
                Form2 crudForm = new Form2(this);
                //opens form2
                crudForm.Show();

                return;
            }
            msgList.Text = "Incorrect Password. Try again.";
        }
        else
        {
            msgList.Text = "User does not exist. Try again.";
        }
    }

        public string encryptPassword(string password)
        {
            //using discards obj after use
            //creates hashing obj
            using (SHA256 sha = SHA256.Create())
            {
                //converts each char to its utf code / num
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                //calls the hashing method 
                byte[] hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        */


        /*if user wants to do CRUD on products


        
         try
        {
           Convert.ToDouble(price)

         //Validation product = new Validation(name, desc,category, price)
        }
        catch
        {
            print "Price must be number"
        }

         */



        //if user wants to do CRUD on Locations
        //Validation product = new Validation(Name, address, Type)


        /*if user wants to do CRUD on Stock       
          try
         {
            Convert.ToDouble(quantity)

          Validation product = new Validation(ProductID(?), LocationID(?), Quantity)
         }
         catch
         {
             print "Quantity must be number"
         }


          */
    }
}

