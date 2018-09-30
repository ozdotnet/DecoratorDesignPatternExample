using DecoratorDesignPatternExample.Core.Domain;

namespace DecoratorDesignPatternExample
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class LibraryItemDecorator : LibraryItem
    {
        //libraryItem object which will be decorated
        protected LibraryItem libraryItem;

        public LibraryItemDecorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}