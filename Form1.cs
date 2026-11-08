namespace EstructurasNoLineales
{
    public partial class Form1 : Form
    {
        private BinarySearchTree bst = new BinarySearchTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text.Trim(), out int valor))
            {
                bool insertado = bst.Add(valor);

                lstResultados.Items.Clear();
                if (insertado)
                {
                    lstResultados.Items.Add($"Éxito: Se insertó el valor {valor}");
                }
                else
                {
                    lstResultados.Items.Add($"Aviso: No se pudo insertar.");
                }

                // Mostrar el mensaje detallado del caso evaluado en el árbol
                lstResultados.Items.Add(bst.LastCaseMessage);
                lstResultados.Items.Add($"----------------------------------------");
                lstResultados.Items.Add($"Total de nodos en el árbol: {bst.Count()} | Altura: {bst.GetHeight()}");

                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text.Trim(), out int valor))
            {
                bool encontrado = bst.Search(valor);

                lstResultados.Items.Clear();
                if (encontrado)
                {
                    lstResultados.Items.Add($"¡Resultado: El valor {valor} SÍ se encuentra en el árbol!");
                }
                else
                {
                    lstResultados.Items.Add($"Resultado: El valor {valor} NO existe en el árbol.");
                }

                lstResultados.Items.Add(bst.LastCaseMessage);
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido para buscar.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text.Trim(), out int valor))
            {
                bool eliminado = bst.Remove(valor);

                lstResultados.Items.Clear();
                if (eliminado)
                {
                    lstResultados.Items.Add($"Éxito: Nodo {valor} eliminado correctamente.");
                }
                else
                {
                    lstResultados.Items.Add($"Aviso: No se pudo eliminar el nodo {valor}.");
                }

                lstResultados.Items.Add(bst.LastCaseMessage);
                lstResultados.Items.Add($"----------------------------------------");
                lstResultados.Items.Add($"Total de nodos restantes: {bst.Count()} | Altura: {bst.GetHeight()}");

                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido para eliminar.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecorridos_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            if (bst.Root == null)
            {
                lstResultados.Items.Add("El árbol está vacío. No hay recorridos que mostrar.");
                return;
            }

            lstResultados.Items.Add("=== RECORRIDOS EN PROFUNDIDAD (ABB) ===");

            // Inorden: Izquierda -> Raíz -> Derecha (Devuelve elementos ordenados de menor a mayor)
            string inOrden = TreeTraversals.InOrder(bst.Root);
            lstResultados.Items.Add($"1. Inorden (Izq -> Raíz -> Der):");
            lstResultados.Items.Add($"   [ {inOrden.Trim()} ]");

            // Preorden: Raíz -> Izquierda -> Derecha
            string preOrden = TreeTraversals.PreOrder(bst.Root);
            lstResultados.Items.Add($"2. Preorden (Raíz -> Izq -> Der):");
            lstResultados.Items.Add($"   [ {preOrden.Trim()} ]");

            // Postorden: Izquierda -> Derecha -> Raíz
            string postOrden = TreeTraversals.PostOrder(bst.Root);
            lstResultados.Items.Add($"3. Postorden (Izq -> Der -> Raíz):");
            lstResultados.Items.Add($"   [ {postOrden.Trim()} ]");

            lstResultados.Items.Add($"----------------------------------------");
            lstResultados.Items.Add($"Nodos totales: {bst.Count()} | Altura del árbol: {bst.GetHeight()}");
        }
    }
    
}
