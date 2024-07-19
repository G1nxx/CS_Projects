using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Task_1
{
    internal class MySetOfCharacters
    {
        private char[] characters;

        public int power;
        public char this[int index] { get { return characters[index]; } }
        public MySetOfCharacters()
        {
            power = 0;
            characters = new char[10];
        }
        public MySetOfCharacters(string characters)
        {
            power = 0;
            this.characters = new char[characters.Length];
            foreach (char c in characters) 
            { 
                this.Push_Back(c);
            }
        }
        private bool Check(char characterToCheck)
        {
            for (int i = 0; i < this.power; i++)
            {
                if (characters[i] == characterToCheck) { return false; }
            }
            return true;
        }

        private void Resize()
        {
            char[] temp = new char[characters.Length * 2];
            for (int i = 0; i < characters.Length; i++)
            {
                temp[i] = characters[i];
            }
            characters = temp;
        }

        public void Push_Back(char characterToPush)
        {
            if (Check(characterToPush))
            {
                if (power == characters.Length) { Resize(); }
                characters[power] = characterToPush;
                power++;
            }
        }

        public static MySetOfCharacters operator +(MySetOfCharacters that, MySetOfCharacters other)
        {
            MySetOfCharacters temp = new MySetOfCharacters();
            foreach (char characterToPush in other.characters)
            {
                temp.Push_Back(characterToPush);
            }
            foreach (char characterToPush in that.characters)
            {
                temp.Push_Back(characterToPush);
            }
            return temp;
        }
        public static MySetOfCharacters operator -(MySetOfCharacters that, MySetOfCharacters other)
        {
            MySetOfCharacters temp = new MySetOfCharacters();
            bool checker;
            foreach (char characterToPush in that.characters)
            {
                checker = true;
                foreach (char characterToCheck in other.characters)
                {
                    if (characterToCheck == characterToPush)
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker) { temp.Push_Back(characterToPush); }
            }
            return temp;
        }
        public static MySetOfCharacters operator *(MySetOfCharacters that, MySetOfCharacters other)
        {
            MySetOfCharacters temp = new MySetOfCharacters();
            bool checker;
            foreach (char characterToPush in that.characters)
            {
                checker = false;
                foreach (char characterToCheck in other.characters)
                {
                    if (characterToCheck == characterToPush)
                    {
                        checker = true;
                        break;
                    }
                }
                if (checker) { temp.Push_Back(characterToPush); }
            }
            return temp;
        }
        public static bool operator ==(MySetOfCharacters that, MySetOfCharacters other)
        {
            if (that.characters == null || other.characters == null) { return false; }
            else
            {
                if (that.power == other.power)
                {
                    Array.Sort(that.characters);
                    Array.Sort(other.characters);
                    for (int i = 0; i < that.power; i++)
                    {
                        if (that.characters[i] != other.characters[i]) { return false; }
                    }
                }
                else { return false; }
            }
            return true;
        }
        public static bool operator !=(MySetOfCharacters that, MySetOfCharacters other)
        {
            if (that.characters == null || other.characters == null) { return true; }
            else
            {
                if (that.power == other.power)
                {
                    Array.Sort(that.characters);
                    Array.Sort(other.characters);
                    for (int i = 0; i < that.power; i++)
                    {
                        if (that.characters[i] != other.characters[i]) { return true; }
                    }
                }
                else { return true; }
            }
            return false;
        }

        public override string ToString()
        {
            return new string(this.characters);
        }
    }
}
