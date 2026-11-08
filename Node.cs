using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasNoLineales
{
    internal class Node
    {
        public int Id;          // Valor o identificador numérico almacenado
        public Node? Left;      // Puntero al hijo izquierdo (valores menores)
        public Node? Right;     // Puntero al hijo derecho (valores mayores)

        public Node(int id)
        {
            Id = id;
            Left = null;
            Right = null;
        }
    }
}
