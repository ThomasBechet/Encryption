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
            Encrypt(Key_TextBox.Text, Input_TextBox.Text);
        }
        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            Decrypt(Key_TextBox.Text, Output_TextBox.Text);
        }

        private struct Pair
        {
            public char character;
            public int position;
        }

        private void Encrypt(string key, string message)
        {
            // On détermine les positions des lettres de la clé
            int[] order = new int[key.Length];

            Pair[] sortedArray = new Pair[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                sortedArray[i] = new Pair();
                sortedArray[i].character = key[i];
                sortedArray[i].position = i;
            }
            sortedArray = sortedArray.OrderBy(item => item.character).ToArray();

            for (int i = 0; i < key.Length; i++)
                order[i] = sortedArray[i].position;

            // On remplit le tableau avec le message
            string[] tab = new string[key.Length];
            for (int i = 0; i < message.Length; i++)
                tab[i % key.Length] += message[i];

            // On lit le tableau colonne par colonne
            Output_TextBox.Text = "";
            foreach (int index in order)
                Output_TextBox.Text += tab[index];
        }
        private void Decrypt(string key, string message)
        {
            // On détermine les positions des lettres de la clé
            int[] order = new int[key.Length];

            Pair[] sortedArray = new Pair[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                sortedArray[i] = new Pair();
                sortedArray[i].character = key[i];
                sortedArray[i].position = i;
            }
            sortedArray = sortedArray.OrderBy(item => item.character).ToArray();

            for (int i = 0; i < key.Length; i++)
                order[i] = sortedArray[i].position;

            // On remplit le tableau
            int lineCount = message.Length / key.Length;

            char[] tab = new char[lineCount * key.Length];
            foreach (int index in order)
            {

            }
        }
    }
}
