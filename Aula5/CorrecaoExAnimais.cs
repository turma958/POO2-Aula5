//abstract class BaseAnimal
//{
//    public string Nome { get; set; }
//    public DateTime DataNascimento { get; set; }
//    public char Sexo { get; set; }
//    public abstract bool Carnivoro { get; }

//    public int Idade()
//    {
//        return (DateTime.Now - DataNascimento).Days / 365;
//    }

//    public abstract void Movimentar();
//    public abstract void Comunicar();
//    public abstract void Alimentar();
//}

//abstract class Mamifero : BaseAnimal
//{
//    public int QtdMamas { get; set; }
//    public bool Pelos { get; set; }
//    public string CorPelo { get; set; }

//    public void Amamentar()
//    {
//    }
//}

//abstract class Reptil : BaseAnimal
//{
//    public bool TemEscamas { get; set; }
//    public bool TemCasco { get; set; }
//}

//abstract class Ave : BaseAnimal
//{
//    public abstract bool Rapina { get;}
//    public string CorPena { get; set; }
//}

//interface IOviparo
//{
//    public void Botar();
//    public void Chocar();
//}

//interface IVoar
//{
//    int AltitudadeMaximaMetros { get; }
//    double VelocidadeVoo { get; }

//    void Voar();
//    void Movimentar();
//}

//interface ICisca
//{
//    void Ciscar();
//}

//interface IAquatico
//{
//    bool ViveEmTerra { get; }
//    bool Mergulho { get; }
//    bool AguaDoce { get; }

//    void Movimentar();
//}

//class Leao : Mamifero
//{
//    public override bool Carnivoro => true;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo carne");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Rugindo");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Caminhando");
//    }
//}

//class Chacal : Mamifero
//{
//    public override bool Carnivoro => true;

//    public override void Alimentar()
//    {
//        Console.Write("Comendo carne/fruta/planta");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Regougar");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Caminhando");
//    }
//}

//class Morcego : Mamifero, IVoar
//{
//    public override bool Carnivoro => false;
//    public int AltitudadeMaximaMetros => 10;
//    public double VelocidadeVoo => 50;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo frutas");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Farfalhando");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Voando");
//    }

//    public void Voar()
//    {
//        Console.WriteLine($"Voando a {VelocidadeVoo} km/h");
//    }
//}

//class Cisne : Ave, IAquatico, IVoar
//{
//    public override bool Rapina => false;
//    public override bool Carnivoro => false;
//    public bool ViveEmTerra => true;
//    public bool Mergulho => false;
//    public bool AguaDoce => true;
//    public int AltitudadeMaximaMetros => 5;
//    public double VelocidadeVoo => 10;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo plantas aquáticas");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Grunhindo");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Caminhando");
//    }

//    void IVoar.Movimentar()
//    {
//        Console.WriteLine("Voando");
//    }

//    void IAquatico.Movimentar()
//    {
//        Console.WriteLine("Nadando");
//    }

//    public void Voar()
//    {
//        Console.WriteLine("Voando");
//    }
//}

//class Arara : Ave, IVoar
//{
//    public override bool Rapina => true;
//    public override bool Carnivoro => false;
//    public int AltitudadeMaximaMetros => 30;
//    public double VelocidadeVoo => 30;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo frutas");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Palrarando");
//    }

//    public override void Movimentar()
//    {
//        Voar();
//    }

//    public void Voar()
//    {
//        Console.WriteLine("Voando");
//    }
//}

//class DragaoDeComo : Reptil, IOviparo
//{
//    public override bool Carnivoro => true;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo carniça");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Silvando");
//    }
//    public void Botar()
//    {
//        Console.WriteLine("Botando");
//    }

//    public void Chocar()
//    {
//        Console.WriteLine("Chocando");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Caminhando");
//    }
//}

//class Ornitorrinco : Mamifero, IAquatico, IOviparo
//{
//    public bool ViveEmTerra => true;
//    public bool Mergulho => true;
//    public bool AguaDoce => true;
//    public override bool Carnivoro => true;

//    public override void Alimentar()
//    {
//        Console.WriteLine("Comendo plantas aquáticas/camarão");
//    }

//    public void Botar()
//    {
//        Console.WriteLine("Botando");
//    }

//    public void Chocar()
//    {
//        Console.WriteLine("Chocando");
//    }

//    public override void Comunicar()
//    {
//        Console.WriteLine("Grunhindo");
//    }

//    public override void Movimentar()
//    {
//        Console.WriteLine("Caminhando");
//    }

//    void IAquatico.Movimentar()
//    {
//        Console.WriteLine("Nadando");
//    }
//}