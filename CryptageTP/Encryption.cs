using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptageTP
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            if (Key_TextBox.Text != "")
            {
                Encrypt(Key_TextBox.Text, Input_TextBox.Text);
            }
        }
        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            if (Key_TextBox.Text != "")
            {
                Decrypt(Key_TextBox.Text, Output_TextBox.Text);
            }
        }

        readonly char EndCharacter = 'उ';

        private struct CharacterPositionPair
        {
            public char character;
            public int position;
        }

        private int[] GetOrderArray(string key)
        {
            // On détermine les positions des lettres de la clé
            int[] order = new int[key.Length];

            CharacterPositionPair[] sortedArray = new CharacterPositionPair[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                sortedArray[i] = new CharacterPositionPair();
                sortedArray[i].character = key[i];
                sortedArray[i].position = i;
            }
            sortedArray = sortedArray.OrderBy(item => item.character).ToArray();

            for (int i = 0; i < key.Length; i++)
                order[i] = sortedArray[i].position;

            return order;
        }

        private string EncryptMessage(string key, string message)
        {
            // Ajout du caractère de fin
            message += EndCharacter;

            int[] order = GetOrderArray(key);

            int columnLength = (int)(Math.Ceiling((double)(message.Length) / (double)(key.Length)));

            char[] tab = new char[columnLength * key.Length];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = ' ';

            for (int i = 0; i < message.Length; i++)
                tab[i] = message[i];

            string output = "";
            foreach (int orderIndex in order)
            {
                for (int i = 0; i < columnLength; i++)
                {
                    output += tab[i * key.Length + orderIndex];
                }
            }

            return output;
        }

        private string DecryptMessage(string key, string message)
        {
            int[] order = GetOrderArray(key);

            // On remplit le tableau
            int columnLength = (int)(Math.Ceiling((double)(message.Length) / (double)(key.Length)));

            char[] tab = new char[columnLength * key.Length];

            int orderIndex = 0;
            int columnIndex = 0;
            foreach (char c in message)
            {
                if (columnIndex >= columnLength || c == EndCharacter)
                {
                    orderIndex++;
                    columnIndex = 0;
                }

                if (c != EndCharacter)
                {
                    tab[order[orderIndex] + columnIndex * key.Length] = c;
                    columnIndex++;
                }
            }

            return new string(tab);
        }

        private void Encrypt(string key, string message)
        {
            Output_TextBox.Text = EncryptMessage(key, message);
        }
        private void Decrypt(string key, string message)
        {
            Input_TextBox.Text = DecryptMessage(key, message);
        }
    }
}
