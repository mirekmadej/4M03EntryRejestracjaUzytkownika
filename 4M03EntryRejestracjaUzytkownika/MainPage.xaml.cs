namespace _4M03EntryRejestracjaUzytkownika
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void onBtnClicked(object sender, EventArgs e)
        {
            string s = "";
            
            if (enImie.Text == null || enImie.Text.Length == 0)
            {
                lblWynik.Text = "puste imię";
                return;
            }
            if (enNazwisko.Text == null || enNazwisko.Text.Length == 0)
            {
                lblWynik.Text = "puste nazwisko";
                return;
            }
            if (enEmail.Text == null || enEmail.Text.Length == 0)
            {
                lblWynik.Text = "pusty email";
                return;
            }
            //sprawdzić czy zawiera znak @
            if( ! enEmail.Text.Contains("@"))
            {
                lblWynik.Text = "to nie jest poprtawny adres email";
                return;
            }

            if (enHaslo1.Text == null || enHaslo1.Text.Length == 0)
            {
                lblWynik.Text = "puste hasło";
                return;
            }
            if (enHaslo2.Text == null || enHaslo2.Text.Length == 0)
            {
                lblWynik.Text = "puste powtórznone hasło";
                return;
            }
            //sprawdzić czy hasła są takie same
            if(enHaslo1.Text != enHaslo2.Text)
            {
                lblWynik.Text = "hasła są różne";
                return;
            }


            s = "konto utworzone poprawnie: ";
            s += enImie.Text + " " + enNazwisko.Text + " ";
            s += enEmail.Text + " " + enHaslo1.Text + " " + enHaslo2.Text;
            lblWynik.Text = s;

        }



    }

}
