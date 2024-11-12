namespace Ordering
{
    public partial class Form1 : Form
    {
        private int[] numbers; // Arreglo para almacenar los números a ordenar
        public Form1()
        {
            InitializeComponent();
            // Configurar el modo de vista del ListView
            listViewSteps.View = View.Details;
            listViewSteps.Columns.Add("Descripción", 120); // Columna para descripción
            listViewSteps.Columns.Add("Arreglo", 300);     // Columna para mostrar el arreglo
            listViewSteps.FullRowSelect = true;
            listViewSteps.GridLines = true;
        }
        // Método para leer los números del TextBox y asignarlos al arreglo
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                numbers = txtInput.Text.Split(',')
                    .Select(int.Parse)
                    .ToArray();

                if (numbers.Length != 8)
                {
                    MessageBox.Show("Por favor, ingrese exactamente 8 números separados por comas.");
                    return;
                }

                ShuffleArray(numbers);
                listViewSteps.Items.Clear();
                DisplayArray(numbers, "Arreglo inicial revuelto");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números separados por comas, sin espacios.");
            }
        }

        private void ShuffleArray(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private void DisplayArray(int[] array, string description)
        {
            var item = new ListViewItem(description); // Crear un nuevo elemento de lista con la descripción
            item.SubItems.Add(string.Join(", ", array)); // Agregar el arreglo como texto en la segunda columna
            listViewSteps.Items.Add(item); // Agregar el elemento al ListView
            
        }

        
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.MergeSort(numbers, 0, numbers.Length - 1, DisplayArray);
        }

        private void btnMezclaDirecta_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.MezclaDirecta(numbers, DisplayArray);
        }

        private void btnMezclaNatural_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.MezclaNatural(numbers, DisplayArray);
        }

       
    }
}
