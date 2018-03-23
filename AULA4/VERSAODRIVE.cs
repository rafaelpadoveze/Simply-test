using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            decimal saldo = 0;
            decimal temp;
            do
            {
                Console.WriteLine("\n\n\n------------------------------------------");
                Console.WriteLine("| | DIGITE 1 PARA CONSULTAR SEU SALDO   | |");
                Console.WriteLine("| | DIGITE 2 PARA SACAR                 | |");
                Console.WriteLine("| | DIGITE 3 PARA DEPÓSITO              | |");
                Console.WriteLine("| | OU DIGITE 0 PARA SAIR               | |");
                Console.WriteLine("------------------------------------------");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Seu saldo atual é: " + saldo.ToString("C2"));//formatação reais
                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    Console.Write("Quanto deseja Retirar?\nR$");
                    temp = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo - temp;
                    Console.WriteLine("seu dinheiro sairá pelo drive de cd abaixo...");

                    EjectMedia.Eject(@"\\.\D:");


                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                    temp = 0;
                }
                else if (opcao == 3)
                {
                    Console.Write("Informe o valor de deposito... \nR$");
                    temp = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo + temp;
                    Console.WriteLine("Seu dinheiro foi depositado com sucesso!!!");
                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                    temp = 0;
                }
                else
                {
                    Console.WriteLine("OPÇÂO INVALIDA");
                }


            }
            while (opcao != 0);
            Console.WriteLine("OBRIGADO POR UTILIZAR O BANCO DO BRASIL 4.0, AGORA SEU SALDO SERÁ ZERADO");



            Console.ReadLine();
            // My CDROM is on drive E:
            
        }
    }

    class EjectMedia
    {
        // Constants used in DLL methods
        const uint GENERICREAD = 0x80000000;
        const uint OPENEXISTING = 3;
        const uint IOCTL_STORAGE_EJECT_MEDIA = 2967560;
        const int INVALID_HANDLE = -1;

        // File Handle
        private static IntPtr fileHandle;
        private static uint returnedBytes;
        // Use Kernel32 via interop to access required methods
        // Get a File Handle
        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr CreateFile(string fileName,
        uint desiredAccess,
        uint shareMode,
        IntPtr attributes,
        uint creationDisposition,
        uint flagsAndAttributes,
        IntPtr templateFile);
        [DllImport("kernel32", SetLastError = true)]
        static extern int CloseHandle(IntPtr driveHandle);
        [DllImport("kernel32", SetLastError = true)]
        static extern bool DeviceIoControl(IntPtr driveHandle,
        uint IoControlCode,
        IntPtr lpInBuffer,
        uint inBufferSize,
        IntPtr lpOutBuffer,
        uint outBufferSize,
        ref uint lpBytesReturned,
                 IntPtr lpOverlapped);

        public static void Eject(string driveLetter)
        {
            try
            {
                // Create an handle to the drive
                fileHandle = CreateFile(driveLetter,
                 GENERICREAD,
                 0,
                 IntPtr.Zero,
                 OPENEXISTING,
                 0,
                  IntPtr.Zero);
                if ((int)fileHandle != INVALID_HANDLE)
                {
                    // Eject the disk
                    DeviceIoControl(fileHandle,
                     IOCTL_STORAGE_EJECT_MEDIA,
                     IntPtr.Zero, 0,
                     IntPtr.Zero, 0,
                     ref returnedBytes,
                            IntPtr.Zero);
                }
            }
            catch
            {
                throw new Exception(Marshal.GetLastWin32Error().ToString());
            }
            finally
            {
                // Close Drive Handle
                CloseHandle(fileHandle);
                fileHandle = IntPtr.Zero;
            }
        }
    }
}
