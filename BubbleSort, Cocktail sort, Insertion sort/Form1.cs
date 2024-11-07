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

            int[] Numbers = TxtDataNum.Text.Split(' ').Select(int.Parse).ToArray();

            organizar.OnSwap += UpdateListBox;
            organizar.BubbleSort(Numbers);
            organizar.OnSwap -= UpdateListBox;

        }

        private void UpdateListBox(int[] numbers)
        {
            string line = string.Join(" ", numbers);
            LsBoxOrder.Items.Add(line);
        }

    }
}
