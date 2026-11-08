using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasNoLineales
{
    internal class TreeTraversals
    {
        public static string InOrder(Node? current)
        {
            if (current == null) return "";
            return $"{InOrder(current.Left)}{current.Id} {InOrder(current.Right)}";
        }

        public static string PreOrder(Node? current)
        {
            if (current == null) return "";
            return $"{current.Id} {PreOrder(current.Left)}{PreOrder(current.Right)}";
        }

        public static string PostOrder(Node? current)
        {
            if (current == null) return "";
            return $"{PostOrder(current.Left)}{PostOrder(current.Right)}{current.Id} ";
        }
    }
}
