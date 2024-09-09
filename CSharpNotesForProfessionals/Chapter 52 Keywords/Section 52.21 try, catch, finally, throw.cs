using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_21
{
    internal class Section_52_21
    {
        internal Section_52_21()
        {
            var processor = new InputProcessor();

            try
            {
                processor.Process("input");
            }
            catch (FormatException ex)
            {
                throw new InvalidCastException("Invalid input", ex);
            }
            catch
            {

                LogUnexpectedException();
                throw;
            }
            finally
            {
                processor.Dispose();
            }
        }
        void LogUnexpectedException()
        {

        }
    }
    internal class InputProcessor
    {
        internal void Open()
        {

        }
        internal void Process(string input)
        {
        }
        internal void Dispose()
        {

        }
    }
}
