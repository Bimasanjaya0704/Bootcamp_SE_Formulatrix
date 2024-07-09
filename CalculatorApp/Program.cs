using System.Configuration.Assemblies;
using CalculatorLib;
class Program
{
	static void Main()
	{
		string ulang;
		do
		{
			// Pemilihan Jenis Operasi
			Calculator calculatorApp = new Calculator();
			Console.Write("A = Penjumlahan\n");
			Console.Write("B = Penguragan\n");
			Console.Write("C = Perkalian\n");
			Console.Write("D = Pembagian\n");
			Console.Write("Pilih Jenis Operasi aritmatika diatas : ");

			// Kondisi jika memasukan input selain pilihan
			string pilihan = Console.ReadLine().ToLower();
			while (pilihan != "c" && pilihan != "b" && pilihan != "c" && pilihan != "d")
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
					Console.WriteLine("Hasil Penjumlahan adalah : " + resultPenjumlahan);
					break;
				case "b":
					int resultPengurangan = calculatorApp.Pengurangan(numberA, numberB);
					Console.WriteLine("Hasil Pengurangan adalah : " + resultPengurangan);
					break;
				case "c":
					int resultPerkalian = calculatorApp.Perkalian(numberA, numberB);
					Console.WriteLine("Hasil Perkalian adalah : " + resultPerkalian);
					break;
				case "d":
					int resultPembagian = calculatorApp.Pembagian(numberA, numberB);
					Console.WriteLine("Hasil Pembagian adalah : " + resultPembagian);
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
