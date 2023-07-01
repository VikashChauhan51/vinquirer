using SysConsole = System.Console;
using System.Security;
using System.Text;

namespace VInquirer.Console;
internal class ConsoleWrapper : IConsole
{
   
    public ConsoleColor BackgroundColor
    {
        get
        {
            return SysConsole.BackgroundColor;
        }
        set
        {
            SysConsole.BackgroundColor = value;
        }
    }

    public int BufferHeight
    {
        get
        {
            return SysConsole.BufferHeight;
        }
        set
        {
            SysConsole.BufferHeight = value;
        }
    }
    public int BufferWidth
    {
        get
        {
            return SysConsole.BufferWidth;
        }
        set
        {
            SysConsole.BufferWidth = value;
        }
    }

    public bool CapsLock
    {
        get
        {
            return SysConsole.CapsLock;
        }
    }

    public int CursorLeft
    {
        get
        {
            return SysConsole.CursorLeft;
        }
        set
        {
            SysConsole.CursorLeft = value;
        }
    }

    public int CursorSize
    {
        get
        {
            return SysConsole.CursorSize;
        }
        set
        {
            SysConsole.CursorSize = value;
        }
    }
    public int CursorTop
    {
        get
        {
            return SysConsole.CursorTop;
        }
        set
        {
            SysConsole.CursorTop = value;
        }
    }

    public bool CursorVisible
    {
        get
        {
            return SysConsole.CursorVisible;
        }
        set
        {
            SysConsole.CursorVisible = value;
        }
    }

    public TextWriter Error
    {
        get
        {
            return SysConsole.Error;
        }
    }

    public ConsoleColor ForegroundColor
    {
        get
        {
            return SysConsole.ForegroundColor;
        }
        set
        {
            SysConsole.ForegroundColor = value;
        }
    }

    public TextReader In
    {
        get
        {
            return SysConsole.In;
        }
    }

    public Encoding InputEncoding
    {
        get
        {
            return SysConsole.InputEncoding;
        }
        set
        {
            SysConsole.InputEncoding = value;
        }
    }

    public bool IsErrorRedirected
    {
        get
        {
            return SysConsole.IsErrorRedirected;
        }
    }

    public bool IsInputRedirected
    {
        get
        {
            return SysConsole.IsInputRedirected;
        }
    }

    public bool IsOutputRedirected
    {
        get
        {
            return SysConsole.IsOutputRedirected;
        }
    }

    public bool KeyAvailable
    {
        get
        {
            return SysConsole.KeyAvailable;
        }
    }

    public int LargestWindowHeight
    {
        get
        {
            return SysConsole.LargestWindowHeight;
        }
    }

 
    public int LargestWindowWidth
    {
        get
        {
            return SysConsole.LargestWindowWidth;
        }
    }
    public bool NumberLock
    {
        get
        {
            return SysConsole.NumberLock;
        }
    }

    public TextWriter Out
    {
        get
        {
            return SysConsole.Out;
        }
    }

    public Encoding OutputEncoding
    {
        get
        {
            return SysConsole.OutputEncoding;
        }
        set
        {
            SysConsole.OutputEncoding = value;
        }
    }

    public string Title
    {
        get
        {
            return SysConsole.Title;
        }
        set
        {
            SysConsole.Title = value;
        }
    }

    public bool TreatControlCAsInput
    {
        get
        {
            return SysConsole.TreatControlCAsInput;
        }
        set
        {
            SysConsole.TreatControlCAsInput = value;
        }
    }
    public int WindowHeight
    {
        get
        {
            return SysConsole.WindowHeight;
        }
        set
        {
            SysConsole.WindowHeight = value;
        }
    }

    public int WindowLeft
    {
        get
        {
            return SysConsole.WindowLeft;
        }
        set
        {
            SysConsole.WindowLeft = value;
        }
    }

    public int WindowTop
    {
        get
        {
            return SysConsole.WindowTop;
        }
        set
        {
            SysConsole.WindowTop = value;
        }
    }

    public int WindowWidth
    {
        get
        {
            return SysConsole.WindowWidth;
        }
        set
        {
            SysConsole.WindowWidth = value;
        }
    }

    public event ConsoleCancelEventHandler CancelKeyPress;

    public void Beep()
    {
        SysConsole.Beep();
    }

    [SecuritySafeCritical]
    public void Beep(int frequency, int duration)
    {
        SysConsole.Beep(frequency, duration);
    }


    [SecuritySafeCritical]
    public void Clear()
    {
        SysConsole.Clear();
    }
    public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth,
        int sourceHeight, int targetLeft, int targetTop)
    {
        SysConsole.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight,
            targetLeft, targetTop);
    }

    [SecuritySafeCritical]
    public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth,
        int sourceHeight, int targetLeft, int targetTop, char sourceChar,
        ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
    {
        SysConsole.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight,
            targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
    }

    public Stream OpenStandardError()
    {
        return SysConsole.OpenStandardError();
    }

    public Stream OpenStandardError(int bufferSize)
    {
        return SysConsole.OpenStandardError(bufferSize);
    }

    public Stream OpenStandardInput()
    {
        return SysConsole.OpenStandardInput();
    }

    public Stream OpenStandardInput(int bufferSize)
    {
        return SysConsole.OpenStandardInput(bufferSize);
    }

    public Stream OpenStandardOutput()
    {
        return SysConsole.OpenStandardOutput();
    }

    public Stream OpenStandardOutput(int bufferSize)
    {
        return SysConsole.OpenStandardOutput(bufferSize);
    }


    public int Read()
    {
        return SysConsole.Read();
    }


    public ConsoleKeyInfo ReadKey()
    {
        return SysConsole.ReadKey();
    }

    [SecuritySafeCritical]
    public ConsoleKeyInfo ReadKey(bool intercept)
    {
        return SysConsole.ReadKey(intercept);
    }


    public string ReadLine()
    {
        return SysConsole.ReadLine();
    }

    [SecuritySafeCritical]
    public void ResetColor()
    {
        SysConsole.ResetColor();
    }

    [SecuritySafeCritical]
    public void SetBufferSize(int width, int height)
    {
        SysConsole.SetBufferSize(width, height);
    }

 
    [SecuritySafeCritical]
    public void SetCursorPosition(int left, int top)
    {
        SysConsole.SetCursorPosition(left, top);
    }

    [SecuritySafeCritical]
    public void SetError(TextWriter newError)
    {
        SysConsole.SetError(newError);
    }

    [SecuritySafeCritical]
    public void SetIn(TextReader newIn)
    {
        SysConsole.SetIn(newIn);
    }


    [SecuritySafeCritical]
    public void SetOut(TextWriter newOut)
    {
        SysConsole.SetOut(newOut);
    }

    [SecuritySafeCritical]
    public void SetWindowPosition(int left, int top)
    {
        SysConsole.SetWindowPosition(left, top);
    }

   
    [SecuritySafeCritical]
    public void SetWindowSize(int width, int height)
    {
        SysConsole.SetWindowSize(width, height);
    }

    public void Write(bool value)
    {
        SysConsole.Write(value);
    }


    public void Write(char value)
    {
        SysConsole.Write(value);
    }

 
    public void Write(char[] buffer)
    {
        SysConsole.Write(buffer);
    }

 
    public void Write(decimal value)
    {
        SysConsole.Write(value);
    }

 
    public void Write(double value)
    {
        SysConsole.Write(value);
    }

 
    public void Write(float value)
    {
        SysConsole.Write(value);
    }

 
    public void Write(int value)
    {
        SysConsole.Write(value);
    }

  
    public void Write(long value)
    {
        SysConsole.Write(value);
    }

    
    public void Write(object value)
    {
        SysConsole.Write(value);
    }

   
    public void Write(string value)
    {
        SysConsole.Write(value);
    }


    [CLSCompliant(false)]
    public void Write(uint value)
    {
        SysConsole.Write(value);
    }

  
    [CLSCompliant(false)]
    public void Write(ulong value)
    {
        SysConsole.Write(value);
    }

    public void Write(string format, object arg0)
    {
        SysConsole.Write(format, arg0);
    }

    public void Write(string format, params object[] arg)
    {
        SysConsole.Write(format, arg);
    }


    public void Write(char[] buffer, int index, int count)
    {
        SysConsole.Write(buffer, index, count);
    }


    public void Write(string format, object arg0, object arg1)
    {
        SysConsole.Write(format, arg0, arg1);
    }


    public void Write(string format, object arg0, object arg1, object arg2)
    {
        SysConsole.Write(format, arg0, arg1, arg2);
    }

    [CLSCompliant(false)]
    public void Write(string format, object arg0, object arg1, object arg2, object arg3)
    {
        SysConsole.Write(format, arg0, arg1, arg2, arg3);
    }

 
    public void WriteLine()
    {
        SysConsole.WriteLine();
    }

    public void WriteLine(bool value)
    {
        SysConsole.WriteLine();
    }

    public void WriteLine(char value)
    {
        SysConsole.WriteLine(value);
    }

    public void WriteLine(char[] buffer)
    {
        SysConsole.WriteLine(buffer);
    }

    public void WriteLine(decimal value)
    {
        SysConsole.WriteLine(value);
    }

    public void WriteLine(double value)
    {
        SysConsole.WriteLine(value);
    }


    public void WriteLine(float value)
    {
        SysConsole.WriteLine(value);
    }


    public void WriteLine(int value)
    {
        SysConsole.WriteLine(value);
    }


    public void WriteLine(long value)
    {
        SysConsole.WriteLine(value);
    }


    public void WriteLine(object value)
    {
        SysConsole.WriteLine(value);
    }

    public void WriteLine(string value)
    {
        SysConsole.WriteLine(value);
    }


    [CLSCompliant(false)]
    public void WriteLine(uint value)
    {
        SysConsole.WriteLine(value);
    }

    [CLSCompliant(false)]
    public void WriteLine(ulong value)
    {
        SysConsole.WriteLine(value);
    }

    public void WriteLine(string format, object arg0)
    {
        SysConsole.WriteLine(format, arg0);
    }

 
    public void WriteLine(string format, params object[] arg)
    {
        SysConsole.WriteLine(format, arg);
    }


    public void WriteLine(char[] buffer, int index, int count)
    {
        SysConsole.WriteLine(buffer, index, count);
    }

 
    public void WriteLine(string format, object arg0, object arg1)
    {
        SysConsole.WriteLine(format, arg0, arg1);
    }

 
    public void WriteLine(string format, object arg0, object arg1, object arg2)
    {
        SysConsole.WriteLine(format, arg0, arg1, arg2);
    }

 
    [CLSCompliant(false)]
    public void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
    {
        SysConsole.WriteLine(format);
    }


}
