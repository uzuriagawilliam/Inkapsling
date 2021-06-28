using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    abstract class UserError
    {
        public abstract string UEMessage();        
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"“You tried to use a numeric input in a numericonly field. This fired an error!” ";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"“You tried to use a text input in a numericonly field. This fired an error!” ";
        }
    }
    class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return $"“You tried to use a null input in a numericonly field. This fired an error!” ";
        }
    }
    class DataInputError : UserError
    {
        public override string UEMessage()
        {
            return $"“You tried to use a data input in a numericonly field. This fired an error!” ";
        }
    }
    class ImageInputError : UserError
    {
        public override string UEMessage()
        {
            return $"“You tried to use a image input in a numericonly field. This fired an error!” ";
        }
    }
    //Polimorfism är viktig att behärska för att det gör skrivandet av kod lättare.
    //Polimorfism gör bland annat at koden blir lättare att förstå och mer flexibel
    //Abstracta klaser tilåter inte a dess metoder blir implementerade men det kan man göra i en Interface 
}
