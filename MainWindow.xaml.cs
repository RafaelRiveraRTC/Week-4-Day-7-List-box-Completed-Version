using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_4_Day_7_List_box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> ItemsnPeople = new List <string> ();



        List<People> people = new List<People>();
       


        List<string> DndItems = new List<string>
        {
            "Potion",
            "BusterSword",
            "SuperLance",
            "BasaliskArmour",
            "Medusa's Head",
            "Dragon's Bane",
            "Javalin of lightning",
            "The throngler",
            "Bob"
        };

        List<string> cranes = new List<string>
        {
            "RTX655",
            "RT865BXL",
            "GMK7450",
            "GMK5350",
            "RT635C"
        };



 




        public MainWindow()
        {
            InitializeComponent();
            ItemsnPeople.Add("Potion");
            ItemsnPeople.Add("Dagger");
            ItemsnPeople.Add("Handaxe");
            ItemsnPeople.Add("Charles");
            ItemsnPeople.Add("Mimic");
            ItemsnPeople.Add("Longsword");
           



            people.Add(new People("Rafael", "Banderes",DndItems));
            people.Add(new People("Charles", "Conan", cranes));
            people.Add(new People("Will", "Calavera", ItemsnPeople));
            //.ItemsSource
            Names.ItemsSource = people;
            Names.SelectedIndex = 0;

           

            PopulateListBox(DndItems, vulnerabilityPhysical.Items);// this cannot handle two lists at once

            PopulateListBox(ItemsnPeople, vulnerabilityElemental.Items);





            //Add data to the list box. How exactly do we do that?
            //.Items is the internal list for listbox
            // that holds the items that will display
            //lbDisplay.Items.Add("Charles");
            //lbDisplay.Items.Add("Mimic");
            //lbDisplay.Items.Add("Longsword");


            //Rafael
            //Charles
            //Will
            //Dylan

            //Names.Items.Add("Rafael");

            //Names.Items.Add("Charles");

            //Names.Items.Add("Will");

            //Names.Items.Add("Dylan");

            // assign the comboboxes currently selected

            //lbCmbSelectedIndex.Content = Names.SelectedIndex;

            //vulnerabilityPhysical.Items.Add("Slashing");

            //vulnerabilityPhysical.Items.Add("Bludgeoning");

            //vulnerabilityPhysical.Items.Add("Piercing");



            //vulnerabilityElemental.Items.Add("Fire");

            //vulnerabilityElemental.Items.Add("Cold");

            //vulnerabilityElemental.Items.Add("Lightning");

        }//MainWindow

        public void PopulateListBox(List<string> ItemsnPeople, ItemCollection itemCollection)
        {
            itemCollection.Clear ();
            foreach (string item in ItemsnPeople)
            {
                itemCollection.Add(item);
            }
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //how do we get the selected item?
            //.Selected

            //Getting the slected index
            //.SelectedIndex
            int selectedIndex = lbDisplay.SelectedIndex;// this will show the number index the list item is associated with
           lblCurrentSelectionIndex.Content = selectedIndex;

            //getting the selected value
            //SelectedItem

            if(lbDisplay.SelectedValue != null)
            {
                string selectedName = lbDisplay.SelectedValue.ToString();// this will display the name that is linked to an index
                namesOfItemsList.Content = selectedName;
            }


          

        }// lbDisplay_SelectionChanged

        private void Names_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedCmbIndex = Names.SelectedIndex;

            lbDisplay.ItemsSource = people[selectedCmbIndex].PersonalList;
        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            //Grab the selected index from the combo box
            int selectedFromCombo = Names.SelectedIndex;
            //access the sleected persons list
            string userValue = txtAddToList.Text;
            //grab the string from the text box
            List<string> userList = people[selectedFromCombo].PersonalList;

            //Add the string to the slected persons box

            userList.Add(userValue);

            //REfresh the list box
            lbDisplay.Items.Refresh();
        }






        //ComboBox
        //ListBox


    }//class

}//namespace