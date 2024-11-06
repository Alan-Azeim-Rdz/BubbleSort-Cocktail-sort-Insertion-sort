namespace BubbleSort__Cocktail_sort__Insertion_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int[] Numbers = TxtDataNum.Text.Split(' ').Select(int.Parse).ToArray();

            BubbleSort(Numbers);

            DataGrideNumber.Rows.Clear();

            foreach (int item in Numbers)
            {
                DataGrideNumber.Rows.Add(item);
            }
        }

        private void BubbleSort(int[] Data)
        {
            int n = Data.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Data[j] > Data[j + 1])
                    {
                        // Intercambiar arr[j] y arr[j + 1]
                        int temp = Data[j];
                        Data[j] = Data[j + 1];
                        Data[j + 1] = temp;
                    }
                }
            }
        }
    }

}
