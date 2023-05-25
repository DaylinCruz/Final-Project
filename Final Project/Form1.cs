using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Para que al correr el programa el picturebox apareza detras de los botones y texto
            pictureboxdog.SendToBack();
        }

        private void dgvanimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btndogs_Click(object sender, EventArgs e)
        {
            BindingList<Dog> dogs = new BindingList<Dog>();
            dgvanimals.DataSource=dogs;
            
            Dog dog1 = new Dog
            {
                Breed = "Husky",
                Name = "Hachiko",
                Age = "2 months",
                Price = "$3500",
            };
            dogs.Add(dog1);

            //Se utilizó este modo para poner tal información en la celda y fila proporcionada dependiendo de donde esta ubicada en el datagridview
            dgvanimals.Rows[0].Cells[0].Value = "They have a lot of energy, they are chewers, look for appropriate toys for their entertainment";
            
            Dog dog2 = new Dog
            {
                Breed = "Chihuahua",
                Name = "Pinky",
                Age = "1 month",
                Price = "1300",
            };
            dogs.Add(dog2);
            dgvanimals.Rows[1].Cells[0].Value = "He is very playful and loves the garden";

            Dog dog3 = new Dog
            {
                Breed = "German Shepherd",
                Name = "Alfa",
                Age = "1 month",
                Price = "4200",
            };
            dogs.Add(dog3);
            dgvanimals.Rows[2].Cells[0].Value = "Does not like to be in the sun too much";

            Dog dog4 = new Dog
            {
                Breed = "Golden Retriever",
                Name = "Conn",
                Age = "2 month",
                Price = "$3100",
            };
            dogs.Add(dog4);
            dgvanimals.Rows[3].Cells[0].Value = "Loves children very much and likes to dig";
        }

        private void btncats_Click(object sender, EventArgs e)
        {
            BindingList<Cat> cats = new BindingList<Cat>();
            dgvanimals.DataSource = cats;

            Cat cat1 = new Cat
            {
                Breed = "Siamese Cat",
                Name = "Anubis",
                Age = "3 months",
                Price = "2100",
            };
            cats.Add(cat1);
            dgvanimals.Rows[0].Cells[0].Value = "He is very affectionate";

            Cat cat2 = new Cat
            {
                Breed = "British Shorthair",
                Name = "Ters",
                Age = "1.5 months",
                Price = "$980",
            };
            cats.Add(cat2);
            dgvanimals.Rows[1].Cells[0].Value = "He is a bit shy";

            Cat cat3 = new Cat
            {
                Breed = "Maine Coon Cat",
                Name = "Molly",
                Age = "1 month",
                Price = "$1400",
            };
            cats.Add(cat3);
            dgvanimals.Rows[2].Cells[0].Value = "She like to have his space and loves toys";

            Cat cat4 = new Cat
            {
                Breed = "Persian Cat",
                Name = "Will",
                Age = "1 months",
                Price = "$2200",
            };
            cats.Add(cat4);
            dgvanimals.Rows[3].Cells[0].Value = "He loves the garden and flowers";

            Cat cat5 = new Cat
            {
                Breed = "Bombay Cat",
                Name = "Brola",
                Age = "2 months",
                Price = "$1890",
            };
            cats.Add(cat5);
            dgvanimals.Rows[4].Cells[0].Value = "She es shy and loving";
        }

        private void btnbirds_Click(object sender, EventArgs e)
        {
            BindingList<Bird> bird = new BindingList<Bird>();
            dgvanimals.DataSource = bird;

            Bird bird1 = new Bird
            {
                Breed = "Canary",
                Name = "You choose it",
                Age = "1 month",
                Price = "$350",
            };
            bird.Add(bird1);
            dgvanimals.Rows[0].Cells[0].Value = "Sings a lot";

            Bird bird2 = new Bird
            {
                Breed = "Dove",
                Name = "You choose it",
                Age = "1 month",
                Price = "$200",
            };
            bird.Add(bird2);
            dgvanimals.Rows[1].Cells[0].Value = "Scares by high noise level";

            Bird bird3 = new Bird
            {
                Breed = "Robin",
                Name = "You choose it",
                Age = "2 months",
                Price = "450",
            };
            bird.Add(bird3);
            dgvanimals.Rows[2].Cells[0].Value = "Likes to eat nuts very much";

            Bird bird4 = new Bird
            {
                Breed = "Parrot",
                Name = "You choose it",
                Age = "20 days",
                Price = "$1600",
            };
            bird.Add(bird4);
            dgvanimals.Rows[3].Cells[0].Value = "Loves to eat nuts, seeds anf fruit";

            Bird bird5 = new Bird
            {
                Breed = "Cockatoo",
                Name = "You choose it",
                Age = "20 days",
                Price = "$780",
            };
            bird.Add(bird5);
            dgvanimals.Rows[4].Cells[0].Value = "Sing a lot in the morning";

            Bird bird6 = new Bird
            {
                Breed = "Canary",
                Name = "You choose it",
                Age = "15 days",
                Price = "$300",
            };
            bird.Add(bird6);
            dgvanimals.Rows[5].Cells[0].Value = "Likes to eat nuts very much";
        }

        private void btnreptiles_Click(object sender, EventArgs e)
        {
            BindingList<Reptil> reptil = new BindingList<Reptil>();
            dgvanimals.DataSource = reptil;

           Reptil reptil1 = new Reptil
            {
                Breed = "Lizard",
                Name = "You choose it",
                Age = "3 months",
               Price = "$250",
            };
            reptil.Add(reptil1);
            dgvanimals.Rows[0].Cells[0].Value = "It´s small, be careful";

            Reptil reptil2 = new Reptil
            {
                Breed = "Tortoise",
                Name = "You choose it",
                Age = "3 months",
                Price = "$980",
            };
            reptil.Add(reptil2);
            dgvanimals.Rows[1].Cells[0].Value = "Likes moist soil and lettuce";

            Reptil reptil3 = new Reptil
            {
                Breed = "Chameleon",
                Name = "You choose it",
                Age = "2 months",
                Price = "$1400",
            };
            reptil.Add(reptil3);
            dgvanimals.Rows[2].Cells[0].Value = "Loves vegetation";

            Reptil reptil4 = new Reptil
            {
                Breed = "Iguana",
                Name = "You choose it",
                Age = "2 months",
                Price = "$1100",
            };
            reptil.Add(reptil4);
            dgvanimals.Rows[3].Cells[0].Value = "Loves carrots and likes to hide";

            Reptil reptil5 = new Reptil
            {
                Breed = "Boa Snake",
                Name = "You choose it",
                Age = "2 months",
                Price = "$3200",
            };
            reptil.Add(reptil5);
            dgvanimals.Rows[4].Cells[0].Value = "It´s scary, be careful. Keep away from childrens";

            Reptil reptil6 = new Reptil
            {
                Breed = "Boa Snake",
                Name = "You choose it",
                Age = "1 month",
                Price = "3200",
            };
            reptil.Add(reptil6);
            dgvanimals.Rows[5].Cells[0].Value = "Keep away from childrens";

            Reptil reptil7 = new Reptil
            {
                Breed = "Ball Python",
                Name = "You choose it",
                Age = "4 months",
                Price = "$3999",
            };
            reptil.Add(reptil7);
            dgvanimals.Rows[6].Cells[0].Value = "They are shy, keep away from childrens";
        }

        private void btnrodents_Click(object sender, EventArgs e)
        {
            BindingList<Rodent> rodent = new BindingList<Rodent>();
            dgvanimals.DataSource = rodent;

            Rodent rodent1 = new Rodent
            {
                Breed = "Rabbit",
                Name = "You choose it",
                Age = "1 month",
                Price = "$150",
            };
            rodent.Add(rodent1);
            dgvanimals.Rows[0].Cells[0].Value = "Likes to eat nuts, seems, lettuce and other vegetables";

            Rodent rodent2 = new Rodent
            {
                Breed = "Raccon",
                Name = "You choose it",
                Age = "1 month",
                Price = "$350",
            };
            rodent.Add(rodent2);
            dgvanimals.Rows[1].Cells[0].Value = "Likes to eat nuts very much";

            Rodent rodent3 = new Rodent
            {
                Breed = "Squirrel",
                Name = "You choose it",
                Age = "3 months",
                Price = "$700",
            };
            rodent.Add(rodent3);
            dgvanimals.Rows[2].Cells[0].Value = "Likes to eat nuts very much and the open air";

            Rodent rodent4 = new Rodent
            {
                Breed = "Hamster",
                Name = "You choose it",
                Age = "2 months",
                Price = "$820",
            };
            rodent.Add(rodent4);
            dgvanimals.Rows[3].Cells[0].Value = "Loves to climb";

            Rodent rodent5 = new Rodent
            {
                Breed = "Rat",
                Name = "You choose it",
                Age = "1 month",
                Price = "$70",
            };
            rodent.Add(rodent5);
            dgvanimals.Rows[4].Cells[0].Value = "Take good care of them, they are fast and like to climb";

            Rodent rodent6 = new Rodent
            {
                Breed = "Hamster",
                Name = "You choose it",
                Age = "3 months",
                Price = "$680",
            };
            rodent.Add(rodent6);
            dgvanimals.Rows[5].Cells[0].Value = "Likes to climb and eat";

            Rodent rodent7 = new Rodent
            {
                Breed = "Rabbit",
                Name = "You choose it",
                Age = "2 months",
                Price = "$140",
            };
            rodent.Add(rodent7);
            dgvanimals.Rows[6].Cells[0].Value = "It is very energetic";
        }

        private void btnfish_Click(object sender, EventArgs e)
        {
            BindingList<Fish> fish = new BindingList<Fish>();
            dgvanimals.DataSource = fish;

            Fish fish1 = new Fish
            {
                Breed = "Angelfish",
                Name = "You choose it",
                Age = "1 month",
                Price = "$520",
            };
            fish.Add(fish1);
            dgvanimals.Rows[0].Cells[0].Value = "Keep their water well cleaned and keep in a safe place";

            Fish fish2 = new Fish
            {
                Breed = "Clownfish",
                Name = "You choose it",
                Age = "1 month",
                Price = "$430",
            };
            fish.Add(fish2);
            dgvanimals.Rows[1].Cells[0].Value = "Keep their water well cleaned and keep in a safe place";

            Fish fish3 = new Fish
            {
                Breed = "Pike",
                Name = "You choose it",
                Age = "1 month",
                Price = "$690",
            };
            fish.Add(fish3);
            dgvanimals.Rows[2].Cells[0].Value = "Keep their water well cleaned and keep in a safe place";

            Fish fish4 = new Fish
            {
                Breed = "Goldenfish",
                Name = "You choose it",
                Age = "2 months",
                Price = "$750",
            };
            fish.Add(fish4);
            dgvanimals.Rows[3].Cells[0].Value = "Keep their water well cleaned and keep in a safe place";

            Fish fish5 = new Fish
            {
                Breed = "Puffer fish",
                Name = "You choose it",
                Age = "1 month",
                Price = "$560",
            };
            fish.Add(fish5);
            dgvanimals.Rows[4].Cells[0].Value = "Keep their water well cleaned and keep in a safe place";

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            //Mostrar mensaje cuando de clic en finalizar el formulario si esta interesado
            MessageBox.Show("¡Data succesfully saved, we will contact you as soon as posible, good day!");

            // Borrar contenido del TextBox antes de mostrar el mensaje
            txtfullname.Text = string.Empty;
            txtage.Text = string.Empty;
            txtphone.Text = string.Empty;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvanimals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}