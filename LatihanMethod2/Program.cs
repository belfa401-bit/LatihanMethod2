int jumlahitem, hargaitem;

decimal diskon, totalbayar;

decimal hitungdiskon(int jml_item)
{
    if (jml_item == 5)
        return 50000;
    else if (jml_item == 10)
        return 75000;
    else
        return 0;
}

decimal hitungtotalbayar(int jml_item, int harga_item , decimal diskon)
{
    return jml_item * harga_item - diskon;
}

Console.WriteLine("masukkan jumlah item: ");
jumlahitem = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan Harga Item");
hargaitem = int.Parse(Console.ReadLine());

diskon = hitungdiskon(jumlahitem);

totalbayar = hitungtotalbayar(jumlahitem, hargaitem, diskon);

Console.WriteLine($"Total Bayar: Rp {totalbayar}");

