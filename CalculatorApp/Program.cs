using CalculatorLib;
class Program
{
	static void Main()
	{
		string ulang;
		Calculator calculatorApp = new Calculator();
		do
		{
			// Pemilihan Jenis Operasi
			Console.Write("A = Penjumlahan\n");
			Console.Write("B = Penguragan\n");
			Console.Write("C = Perkalian\n");
			Console.Write("D = Pembagian\n");
			Console.Write("Pilih Jenis Operasi aritmatika diatas : ");

			// Kondisi jika memasukan input selain pilihan
			string pilihan = Console.ReadLine().ToLower();
			while (pilihan != "a" && pilihan != "b" && pilihan != "c" && pilihan != "d")
			{
				Console.WriteLine("Pilihan tidak valid. Silakan pilih A, B, C, atau D.");
				pilihan = Console.ReadLine().ToLower();
			}

			// masukan input
			Console.Write("Masukan angka ke-1 : ");
			int numberA = int.Parse(Console.ReadLine());
			Console.Write("Masukan angka ke-2 : ");
			int numberB = int.Parse(Console.ReadLine());

			//	melakukan pemilihan sesuai dngan case atau pilihan yang dimasukan oleh user
			switch (pilihan)
			{
				case "a":
					int resultPenjumlahan = calculatorApp.Penjumlahan(numberA, numberB);
					Console.WriteLine("Hasil Penjumlahan antara {0} dan {1} adalah {2}: ", numberA, numberB, resultPenjumlahan);
					break;
				case "b":
					int resultPengurangan = calculatorApp.Pengurangan(numberA, numberB);
					Console.WriteLine("Hasil Pengurangan antara {0} dan {1} adalah {2}: ", numberA, numberB, resultPengurangan);
					break;
				case "c":
					int resultPerkalian = calculatorApp.Perkalian(numberA, numberB);
					Console.WriteLine("Hasil Perkalian antara {0} dan {1} adalah {2}: ", numberA, numberB, resultPerkalian);
					break;
				case "d":
					int resultPembagian = calculatorApp.Pembagian(numberA, numberB);
					Console.WriteLine("Hasil Pembagian antara {0} dan {1} adalah {2}: ", numberA, numberB, resultPembagian);
					break;
				default:
					Console.WriteLine("Pilihan tidak valid.");
					break;
			}
			Console.Write("Apakah Anda ingin melakukan operasi lagi? (y/n) ");
			ulang = Console.ReadLine().ToLower();
		} while (ulang == "y");
	}
}
