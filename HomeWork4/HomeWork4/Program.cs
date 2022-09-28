Student oguz = new Student("Oguz", "2150ru", 24);
oguz.showInfo();
oguz.enterProrammingGrade(5);
oguz.enterProrammingGrade(10);
oguz.enterProrammingGrade(4);
oguz.enterProrammingGrade(8);
oguz.enterAdministrationGrade(4);
oguz.enterAdministrationGrade(7);
oguz.enterAdministrationGrade(2);
oguz.enterAdministrationGrade(10);
oguz.enterAdministrationGrade(11);
oguz.enterDesignGrade(9);
oguz.enterDesignGrade(4);
oguz.enterDesignGrade(5);
oguz.enterDesignGrade(12);
oguz.enterDesignGrade(6);
oguz.showGrades();
Console.WriteLine($"Programming avarage grade is " + oguz.averageProgramming());
Console.WriteLine($"Administratio avarage grade is " + oguz.averageAdministration());
Console.WriteLine($"Design avarage grade is " + oguz.averageDesign());

#region Task_5
enum ArticleType {
    Food, Clothes, Beverages
}
#endregion

#region Task_1
struct Article {
    public int code;
    public String title;
    public int price;
    public ArticleType type;

    public Article(int _code, string _title, int price, ArticleType _type) {
        this.code = _code;
        this.title = _title;
        this.price = price;
        this.type = _type;
    }

    public Article copy(Article other) {
      Article tmp = new Article();  
      tmp.code = other.code;
      tmp.title = other.title;
      tmp.price = other.price;
      tmp.type = other.type;

      return tmp;
    }
}
#endregion

#region Task_6
enum ClientType {
    // Не понял, что такое важность клиента. Кроме ВИП и неВИП ничего в голову не лезет. Пусть будет еще полуВИП.
    VIP, nonVIP, halfVIP
}
#endregion

#region Task_2
struct Client
{
    public int code;
    public string name;
    public string surname;
    public string adress;
    public int tel_number;
    public int orders;
    public int summ_orders;
    public ClientType cType;

    public Client(int _code, string _surname, string _name, string adress, int _tel_number, int _orders, int _summ_orders, ClientType _cType)
    {
        this.code = _code;
        this.name = _name;
        this.surname = _surname;
        this.adress = adress;
        this.tel_number = _tel_number;
        this.orders = _orders;
        this.summ_orders = _summ_orders;
        this.cType = _cType;
    }

    public Client copy(Client other)
    {
        Client tmp = new Client();

        tmp.code = other.code;
        tmp.name = other.name;
        tmp.surname = other.surname;
        tmp.adress = other.adress;
        tmp.tel_number = other.tel_number;
        tmp.orders = other.orders;
        tmp.summ_orders = other.summ_orders;
        tmp.cType = other.cType;

        return tmp;
    }
}
    #endregion

#region Task_3
    struct RequestItem
    {
        public Article item;
        public int quantity;

        public RequestItem(Article _item, int _quantity)
        {
            this.item = _item.copy(_item);
            this.quantity = _quantity;
        }
    }
    #endregion

#region Task_7
    enum PayType
    {
        Card, Cash
    }
    #endregion

#region Task_4
    struct Date
    {
        public int day;
        public int month;
        public int year;

        public Date(int _day, int _month, int _year)
        {
            this.day = _day;
            this.month = _month;
            this.year = _year;
        }
        public Date copy(Date other)
        {
            Date tmp = new Date();

            tmp.day = other.day;
            tmp.month = other.month;
            tmp.year = other.year;
            return tmp;
        }

    }
    struct Request
    {
        public int order_code;
        public Client client;
        public Date date;
        public RequestItem[] item; //идеально подошел бы вектор тут... Не уверен, что просто массив это правильно.
        public PayType payType;
        //"сумма заказа (реализовать вычисляемым свойством)" Я не понял, что от меня хотят в задании и как из этого сделать переменную.
        //Сделаю метод для подсчета, цена и количество все равно уже были переменными в предыдущих структурах.

        public Request(int _order_code, Client _client, Date _date, RequestItem[] _item, PayType _payType)
        {
            this.order_code = _order_code;
            this.client = _client.copy(_client);
            this.date = _date.copy(_date);
            this.item = _item;
            this.payType = _payType;
        }
        public int summ()
        {
            int tmp = 0;

            foreach (RequestItem it in item)
            {
                tmp += it.quantity * it.item.price;
            }
            return tmp;
        }
    }
#endregion

#region Task_8
class Student
{
<<<<<<< HEAD
    public string fullName;
    public string group;
    public int age;
    public int[][] grades = new int[3][] { new int[0], new int[0], new int[0] };

    public Student(string fullName, string group, int age)
    {
        this.fullName = fullName;
        this.group = group;
        this.age = age;
    }

    public void enterProrammingGrade(int grade)
    {
        int[] tmp = new int[grades[0].Length + 1];
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = grades[0][i];
        }
        tmp[tmp.Length - 1] = grade;
        grades[0] = new int[tmp.Length];
        for (int i = 0; i < tmp.Length; i++)
        {
            grades[0][i] = tmp[i];
        }
    }

    public void enterAdministrationGrade(int grade)
    {
        int[] tmp = new int[grades[1].Length + 1];
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = grades[1][i];
        }
        tmp[tmp.Length - 1] = grade;
        grades[1] = new int[tmp.Length];
        for (int i = 0; i < tmp.Length; i++)
        {
            grades[1][i] = tmp[i];
        }
    } 
    
    public void enterDesignGrade(int grade)
    {
        int[] tmp = new int[grades[2].Length + 1];
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = grades[2][i];
        }
        tmp[tmp.Length - 1] = grade;
        grades[2] = new int[tmp.Length];
        for (int i = 0; i < tmp.Length; i++)
        {
            grades[2][i] = tmp[i];
        }
    }
    public void showGrades()
    {
        Console.Write("Programming grades: ");
        for (int i = 0; i < grades[0].Length; i++)
        {
            if (i != grades[0].Length - 1)
            {
                Console.Write($"{grades[0][i]}, ");
            }
            else
            {
                Console.Write($"{grades[0][i]}");

            }
        }

        Console.Write("\nAdministration grades: ");
        for (int i = 0; i < grades[1].Length; i++)
        {
            if (i != grades[1].Length - 1)
            {
                Console.Write($"{grades[1][i]}, ");
            }
            else
            {
                Console.Write($"{grades[1][i]}");

            }
        }

        Console.Write("\nDesign grades: ");
        for (int i = 0; i < grades[2].Length; i++)
        {
            if (i != grades[2].Length - 1)
            {
                Console.Write($"{grades[2][i]}, ");
            }
            else
            {
                Console.Write($"{grades[2][i]}\n");

            }
        }
    }

    public double averageProgramming()
    {
        double tmp = 0;
        for (int i = 0; i < grades[0].Length; i++)
        {
                tmp += grades[0][i];
        }
        return tmp / (grades[0].Length);
    }

        public double averageAdministration()
    {
        double tmp = 0;
        for (int i = 0; i < grades[1].Length; i++)
        {
                tmp += grades[1][i];
        }
        return tmp / (grades[1].Length);
    }
    
        public double averageDesign()
    {
        double tmp = 0;
        for (int i = 0; i < grades[2].Length; i++)
        {
                tmp += grades[2][i];
        }
        return tmp / (grades[2].Length);
    }

    public void showInfo() {
        Console.WriteLine($"Full name: {fullName}");
        Console.WriteLine($"Group: {group}");
        Console.WriteLine($"Age: {age}");
    }
}
#endregion
=======
    public string name;
    public string surname;
    public int age;
    public int[][] evaluation = new int[3][] { new int[0], new int[0], new int[0] };
    

}
#endregion
>>>>>>> 63d77a5e4db5972c94798781eef1cf95994f3779
