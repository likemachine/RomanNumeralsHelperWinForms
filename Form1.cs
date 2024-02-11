namespace RomanNumeralsHelper
{
    public partial class Form1 : Form
    {
        private readonly RomanHelper RomanNumerals = new RomanHelper();

        public Form1()
        {
            InitializeComponent();
            // Добавляем обработчик события Click для кнопки Button6
            Button6.Click += Button6_Click;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Получаем значение из TextBox4
            string inputText = TextBox4.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                // Преобразуем введенное значение в число
                if (int.TryParse(inputText, out int arabicNumber))
                {
                    // Выполняем преобразование в римскую запись
                    string romanResult = RomanNumerals.ToRoman((uint)arabicNumber);

                    // Отображаем результат в Label8
                    Label8.Text = $"Roman: {romanResult}";
                }
                else
                {
                    // В случае ошибки ввода числа
                    Label8.Text = "Invalid input. Please enter a valid number.";
                }
            }

            // Получаем значение из TextBox5
            string romanInput = TextBox5.Text;

            if (!string.IsNullOrWhiteSpace(romanInput))
            {
                // Выполняем преобразование из римской записи
                try
                {
                    int arabicResult = RomanNumerals.FromRoman(romanInput);

                    // Отображаем результат в Label9
                    Label9.Text = $"Arabic: {arabicResult}";
                }
                catch (Exception ex)
                {
                    // В случае ошибки ввода римского числа
                    Label9.Text = $"Error: {ex.Message}";
                }
            }
        }
    }
}