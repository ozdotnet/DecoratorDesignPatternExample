using DecoratorDesignPatternExample.Core.Domain;
using System;
using System.Collections.Generic;

namespace DecoratorDesignPatternExample
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable : LibraryItemDecorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem) { }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}