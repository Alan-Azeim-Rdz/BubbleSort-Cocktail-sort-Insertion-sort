namespace BubbleSort__Cocktail_sort__Insertion_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row = 0;
        int column = 0;
        Organization organizar = new Organization();


        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string seleccion = ComBoxSelect.SelectedItem.ToString();


            int[] Numbers = TxtDataNum.Text.Split(' ').Select(int.Parse).ToArray();

            switch (seleccion)
            {
                case "Bubblesort":
                    organizar.OnSwap += UpdateListBox;
                    organizar.BubbleSort(Numbers);
                    organizar.OnSwap -= UpdateListBox;
                    break;

                case "Cocktail sort":
                    organizar.OnSwap += UpdateListBox;
                    organizar.Cocktail_Sort(Numbers);
                    organizar.OnSwap -= UpdateListBox;
                    break;
            }


        }

        private void UpdateListBox(int[] numbers)
        {
            string line = string.Join(" ", numbers);
            LsBoxOrder.Items.Add(line);
        }

    }
}
