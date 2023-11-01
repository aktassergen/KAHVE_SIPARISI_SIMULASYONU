/*
     ***************main classında aşağıdaki gibi derlenebilir************************

        Urun espresso = new Urun("1", 2, 4, 5.0m);
        Urun americano = new Urun("2", 3, 3, 4.0m);

        UrunYonetimi urunYonetimi = new UrunYonetimi();
        urunYonetimi.urunEkle(espresso);
        urunYonetimi.urunEkle(americano);

        KasiyerYonetimi kasiyerYonetimi = new KasiyerYonetimi();
        for (int i = 0; i < 3; i++)
        {
            Kasiyer kasiyer = new Kasiyer($"{i + 1} Id li kasiyer");
            kasiyerYonetimi.kasiyerEkle(kasiyer);
        }

        CalisanHavuzu calisanHavuzu = new CalisanHavuzu();

        Barista barista = new Barista("1 Id li barista");

        Musteri musteri1 = new Musteri("1 Id li musteri", espresso);
        musteri1.UrunIlaveEkle(espresso, "Karamel");
        musteri1.UrunIlaveEkle(espresso, "Seker");
        musteri1.UrunIlaveCikar(espresso, "Seker");

        Musteri musteri2 = new Musteri("2 Id li musteri", americano);

        kasiyerYonetimi.SiparisAlVeHazirla(musteri1);
        kasiyerYonetimi.SiparisAlVeHazirla(musteri2);

        musteri1.SiparisHazır(barista);
        musteri2.SiparisHazır(barista);

        musteri1.OdemeYap();
        musteri2.OdemeYap();
    
     */


