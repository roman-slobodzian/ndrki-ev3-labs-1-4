# ВСТУП

Методичні вказівки для студентів шостого курсу за спеціальністю «Комп’ютерна інженерія» призначені для набуття практичних навиків розробки та програмування роботизованих систем.

Завдання даного курсу - познайомити з основами та принципами побудови та програмування робототехнічних систем на базі конструктора Lego mindstorms EV3. Навчити будувати конструкції робототехнічних систем, програмувати їх під певні завдання.

**Основною метою лабораторних робіт є:**

- застосовування основ робототехніки для розв’язування задач синтезу робототехнічних систем;
- застосовування знань принципів побудови робототехнічних систем для ідентифікації, формулювання і розв’язування технічних задач спеціальності;
- розробка програмного забезпечення для робототехнічних систем; експлуатувати готові робототехнічні системи;
- застосовування теорії та методів системного аналізу, математичного і комп’ютерного моделювання при проектуванні робототехнічних систем;
- розв’язування складних задач і проблем в галузі проектування робототехнічних систем, що передбачає проведення досліджень та/або здійснення інновацій;
- створення системного та прикладного програмного забезпечення для робототехнічних систем;
- проектування робототехнічних систем та їхні компонентів, програмне забезпечення для робототехнічних систем з урахуванням усіх аспектів їх життєвого циклу ПЗ, включаючи створення, налаштування, експлуатацію та обслуговування.

Структура лабораторних робіт включає мету роботи, короткі теоретичні відомості, методичні вказівки для підготування до роботи та її виконання, індивідуальні завдання до лабораторної роботи, контрольні запитання для підготування до захисту роботи.

Для захисту виконаної лабораторної роботи студентові необхідно підготувати звіт роботи, який винний включати: титульний аркуш із вказанням назви лабораторної роботи, тими лабораторної роботи; завдання для лабораторної роботи; результати роботи програми; висновок, який включає в собі опис виконаної роботи із зазначенням «що зроблено?», «за допомогою чого це зроблено?», «які отримано результати?», «вірність отриманих результатів».

Завдання до кожної лабораторної роботи мають три рівні складності, яки кожен студент обирає на власний розсуд.

Оцінку „відмінно”, за шкалою ECTS – А, отримує студент за вірне і повне опанування змісту навчального матеріалу, в якому він легко орієнтується, понятійного апарату, за уміння зв’язувати теорію з практикою, вирішувати практичні завдання ІІІ рівня складності, висловлювати і обґрунтовувати свої судження.

Оцінку „добре”, за шкалою ECTS – В, отримує студент за повне засвоєння навчального матеріалу, володіння понятійним апаратом, орієнтування в вивченому матеріалі, свідоме використання знань для вирішення практичних завдань, грамотний виклад відповіді, але вирішив практичні завдання лише ІІ рівня складності.

Оцінку „добре”, за шкалою ECTS – С, отримує студент за правильно виконане завдання ІІ рівня складності з двома-трьома суттєвими помилками.

Оцінки "задовільно", за шкалою ECTS – D, заслуговує студент, який виконав завдання ІІ рівня складності та виявив знання основного навчально-програмного матеріалу в обсязі, необхідному для подальшого навчання та практичної діяльності за професією, що справляється з виконанням практичних завдань, передбачених програмою.

Оцінки "задовільно", за шкалою ECTS – E, заслуговує студент за неповне завдання ІІ рівня складності та неповне опанування програмного матеріалу, але отримані знання і набуті практичні навички відповідають мінімальним критеріям оцінювання.

# ЛАБОРАТОРНІ РОБОТИ №5-8

## Програмування робототехнічних систем LEGO Mindstorms EV3 засобами бібліотеки MonoBrick Communication Library та фреймворку BrainPeek

**Мета:** ознайомитися з можливостями технічними можливостями програмування робототехнічних систем LEGO Mindstorms EV3 засобами бібліотеки MonoBrick Communication Library та фреймворку BrainPeek.

## Бібліотека MonoBrick Communication Library

The MonoBrick communication library - це бібліотека LEGO Mindstorms, написана на C#, яка працює зі стандартною прошивкою на EV3. The MonoBrick communication library працює на різних операційних системах, включаючи Linux, Mac OS і Windows. Бібліотека може спілкуватися з EV3 за допомогою USB, Bluetooth або WiFi. Крім того, також можна спілкуватися з EV3 через Інтернет за допомогою тунельного зв'язку. Тоннельне спілкування здійснюється за допомогою тунелю MonoBrick або MonoBrick для Android. Оскільки бібліотека працює як з Mono, так і з Microsoft .Net Framework, вона може бути використана як з Visual Studio, так і з MonoDevelop / Xamarin Studio.

Бібліотека зв'язку MonoBrick має такі функції:

1. встановлює зв’язок з EV3 за допомогою USB, Bluetooth, WiFi або тунельного зв'язку;
2. працювати з операційними системами Linux, Mac OS, Windows, Windows Phone і Android;
3. підтримує усі сенсори LEGO, що постачаються в комплектах Retail and Educational;
4. контролювати мотори окремо або як транспортний засіб;
5. використовувати систему поштової скриньки, щоб надсилати повідомлення / дані до блоку EV3;
6. відтворення звук та звукові файли;
7. використовувати файлову систему для завантаження та завантаження файлів;
8. починати та зупиняти програми на основі блоку EV3;
9. використовувати виключення для виявлення помилок давача та зв'язку;
10. відкривати та закривати з'єднання з декількома блоками EV3;
11. та інше.

### Написання першої програми за допомогою бібліотеки MonoBrick Communication Library

Після того як у одержано робоче підключення, завантажте вихідні файли бібліотеки MonoBrick за допомогою посилання для завантаження та додайте їх у ваш проект. Інший варіант - завантажити тестовий проект і використовувати його як відправну точку. Проект тесту включає вихідні файли та зразок програми, показані нижче. Для отримання додаткових прикладів перегляньте довідник бібліотеки, а також документацію.

```csharp
using System;
using MonoBrick.EV3;
namespace Application
{
    public static class Program {
        static void Main(string[] args)
        {
            try {
                var brick = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
                sbyte speed = 0;
                brick.Connection.Open();
                ConsoleKeyInfo cki;
                Console.WriteLine("Press Q to quit");
                do
                {
                    cki = Console.ReadKey(true); //press a key
                    switch (cki.Key) {
                        case ConsoleKey.R:
                            Console.WriteLine("Motor A reverse direction");
                            brick.MotorA.Reverse = !brick.MotorA.Reverse;
                            break;
                        case ConsoleKey.UpArrow:
                            if (speed < 100)
                                speed = (sbyte)(speed + 10);
                            Console.WriteLine("Motor A speed set to " + speed);
                            brick.MotorA.On(speed);
                            break;
                        case ConsoleKey.DownArrow:
                            if (speed > -100)
                                speed = (sbyte)(speed - 10);
                            Console.WriteLine("Motor A speed set to " + speed);
                            brick.MotorA.On(speed);
                            break;
                        case ConsoleKey.S:
                            Console.WriteLine("Motor A off");
                            speed = 0;
                            brick.MotorA.Off();
                            break;
                        case ConsoleKey.B:
                            Console.WriteLine("Motor A break");
                            speed = 0;
                            brick.MotorA.Brake();
                            break;
                        case ConsoleKey.T:
                            int count = brick.MotorA.GetTachoCount();
                            Console.WriteLine("Motor A tacho count:" + count);
                            break;
                        case ConsoleKey.C:
                            Console.WriteLine("Clear tacho count");
                            brick.MotorA.ResetTacho();
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Enter position to move to.");
                            string input = Console.ReadLine();
                            Int32 position;
                            if (Int32.TryParse(input, out position)) {
                                Console.WriteLine("Move to " + position);
                                brick.MotorA.MoveTo(50, position, false);
                            }
                            else {
                                Console.WriteLine("Enter a valid number");
                            }
                            break;
                    }
                } while (cki.Key != ConsoleKey.Q);
            }
            catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Press any key to end...");
                Console.ReadKey();
            } } }
}
```

### Підключення до блоку

Розглянемо приклади, що показують, як встановити зв'язок як з блоком EV3.

#### USB-з'єднання

Щоб створити USB-порт, переконайтеся, що ви скопіювали файли libusb та файли hipapi, що постачаються з завантаженням бібліотеки зв'язку MonoBrick, у ту ж папку, що і файл exe. Якщо ви використовуєте проект випробувань бібліотеки комунікацій MonoBrick, вам не потрібно турбуватися про це. Наступний код відкриє USB-з'єднання та перемістить двигун А.

```csharp
using System;
using MonoBrick.EV3;
public static class Program {
    static void Main(string[] args)
    {
        var ev3=new Brick<Sensor, Sensor,Sensor, Sensor>("usb");
        try {
            ev3.Connection.Open();
            ev3.MotorA.On(50);
            System.Threading.Thread.Sleep(3000);
            ev3.MotorA.Off();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("Error: " + e.Message);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
        finally{
            ev3.Connection.Close();
        }
    }
}
```

#### З'єднання Bluetooth

Перш ніж користуватись Bluetooth-з'єднанням, переконайтеся, що ви об'єднали комп'ютер з LEGO Brick. Наступний код підключить до блоку за допомогою порту com6.

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("com6");
```

#### WiFi-з'єднання

З'єднання Wi-Fi працює тільки з EV3, і його не слід плутати з тунельним з'єднанням, яке описано нижче. Щоб скористатися Wi-Fi-з'єднанням, потрібно підключити EV3 до мережі Wi-Fi. Після того, як цегла підключена до мережі, замінити наступну рядок з рядка 7 у прикладі usb.

```csharp
var ev3 = new Brick<Sensor,Sensor,Sensor,Sensor>("wifi");
```

#### Тунельне з'єднання

Тунельне з'єднання дає змогу спілкуватися з блоком LEGO, використовуючи тунель MonoBrick або тунель MonoBrick для Android. Це дозволяє спілкуватися як через локальну мережу, так і через WAN. Після того як у вас є тунель, підключений до блоку, використовуйте такий код, щоб створити з'єднання з тунелем, прослуховуючи клієнтів на комп'ютері з IP-адресою 192.168.1.11 на порту 1500.

```csharp
using System;
using MonoBrick.EV3;
public static class Program {
    static void Main(string[] args)
    {
        var nxt = new Brick<Sensor, Sensor, Sensor, Sensor>("192.168.1.11", 1500);
        try {
            nxt.Connection.Open();
            nxt.MotorA.On(50);
            System.Threading.Thread.Sleep(3000);
            nxt.MotorA.Off();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("Error: " + e.Message);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
        finally{
            nxt.Connection.Close();
        }
    }
}
```

Якщо ви хочете, щоб тунель з'єднався з клієнтом, якщо, наприклад, тунель працює за брандмауером, наступний код буде чекати, коли тюнель встановить з'єднання. Замініть ці дві рядки на рядок 6 у прикладі тунелю вище

```csharp
var connection = new MonoBrick.TunnelConnection<Command,Reply>(1500);
var nxt = new Brick<Sensor,Sensor,Sensor,Sensor>(connection);
```

### Контроль двигунів

Управління моторами з бібліотекою зв'язку MonoBrick легко. Наведений нижче код демонструє, як зробити двигун вперед, назад, гальмом та зупинити.

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
ev3.Connection.Open();
ev3.MotorA.On(50);
System.Threading.Thread.Sleep(3000);
ev3.MotorA.On(-50);
System.Threading.Thread.Sleep(3000);
ev3.MotorA.Brake();//motor is still on but does not move
System.Threading.Thread.Sleep(3000);
ev3.MotorA.Off();
ev3.Connection.Close();
```

#### Контроль положення

Наступний приклад демонструє, як зробити рух двигуна відносними та абсолютними позиціями. Під час переїзду в положення, будь ласка, зверніть увагу, що якщо ви не встановите прапорець перривання руху, двигун продовжить рух, коли буде досягнуто положення, і не зупиниться негайно.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static Brick<Sensor, Sensor, Sensor, Sensor> ev3;
    static void Main(string[] args) {
        ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        try {
            ev3.Connection.Open();
            ev3.MotorA.ResetTacho();
            ev3.MotorA.On(50, 6 * 360, true);
            WaitForMotorToStop();
            Console.WriteLine("Position: " + ev3.MotorA.GetTachoCount());
            ev3.MotorA.On(-50, 9 * 360, true);
            WaitForMotorToStop();
            Console.WriteLine("Position: " + ev3.MotorA.GetTachoCount());
            ev3.MotorA.MoveTo(50, 0, true);
            WaitForMotorToStop();
            ev3.MotorA.Off();
            Console.WriteLine("Position: " + ev3.MotorA.GetTachoCount());
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("Error: " + e.Message);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
        finally{
            ev3.Connection.Close();
        }
    }
    static void WaitForMotorToStop()
    { Thread.Sleep(500);
        while (ev3.MotorA.IsRunning()) { Thread.Sleep(50); }
    }}
```

#### Створення профілю моторного рампи

Кроковий профіль дозволяє 300 кроків провернуиь двигун, пройти вперед на 600 кроків зі швидкістю 50, рухатися на 300 кроків і гальмувати, коли це закінчено. Також підтримуються профілі на основі часу.

```csharp
var ev3 = new Brick<Sensor,Sensor,Sensor,Sensor>("usb");
ev3.Connection.Open();
ev3.MotorA.SpeedProfileStep(50,300,600,300,true);
ev3.Connection.Close();
```

#### Синхронізація двигунів

Наведений нижче приклад показує, як синхронізувати двигун А та двигун D. Якщо вам потрібно синхронізувати двигуни для керування транспортним засобом, будь ласка, перегляньте розділ автомобіля нижче.

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
ev3.Connection.Open();
ev3.MotorSync.BitField = OutputBitfield.OutA | OutputBitfield.OutD;
ev3.MotorSync.On(50, 0);
System.Threading.Thread.Sleep(3000);
ev3.MotorSync.On(50, 50);//Motor A runs twice as fast as motor D
System.Threading.Thread.Sleep(3000);
ev3.MotorSync.Brake();
System.Threading.Thread.Sleep(1000);
ev3.MotorSync.StepSync(-50, 0, 6 * 360, false);//Move to a position
ev3.Connection.Close();
```

#### Управління транспортним засобом

Наведений нижче приклад дозволить керувати роботизованою платформою за допомогою клавіатури.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        try {
            ev3.Connection.Open();
            ev3.Vehicle.LeftPort = MotorPort.OutA;
            ev3.Vehicle.RightPort = MotorPort.OutD;
            ev3.Vehicle.ReverseLeft = false;
            ev3.Vehicle.ReverseRight = false;
            sbyte speed = 50;
            ConsoleKeyInfo cki;
            Console.WriteLine("Press T to quit");
            do
            {
                cki = Console.ReadKey(true); //press a key
                switch (cki.Key) {
                    case ConsoleKey.W:
                        ev3.Vehicle.Forward(speed);
                        break;
                    case ConsoleKey.S:
                        ev3.Vehicle.Backward(speed);
                        break;
                    case ConsoleKey.D:
                        ev3.Vehicle.SpinRight(speed);
                        break;
                    case ConsoleKey.A:
                        ev3.Vehicle.SpinLeft(speed);
                        break;
                    case ConsoleKey.Q:
                        ev3.Vehicle.TurnLeftForward(speed, 50);
                        break;
                    case ConsoleKey.E:
                        ev3.Vehicle.TurnRightForward(speed, 50);
                        break;
                    case ConsoleKey.C:
                        ev3.Vehicle.TurnRightReverse(speed, 50);
                        break;
                    case ConsoleKey.Z:
                        ev3.Vehicle.TurnLeftReverse(speed, 50);
                        break;
                    case ConsoleKey.Spacebar:
                        ev3.Vehicle.Off();
                        break;
                }
            } while (cki.Key != ConsoleKey.T);
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("Error: " + e.Message);
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
        finally{
            ev3.Connection.Close();
        }
    }
}
```

Можна також задати кількість кроків руху платформи

```csharp
ev3.Vehicle.Forward(50, 12 * 360);
```

#### Давачі для читання

Комунікаційна бібліотека MonoBrick підтримує датчики LEGO, що поставляються разом з роздрібними та навчальними комплектами EV3, включаючи IR-сенсор, давач кольору, давач гіроскопа та давач температури. Всі датчики успадковують від основного класу давача. У наведеному нижче прикладі використовується базовий клас для відображення значень датчика

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        ev3.Connection.Open();
        ev3.Sensor1 = new IRSensor(IRMode.Proximity);
        ev3.Sensor2 = new TouchSensor();
        ev3.Sensor3 = new ColorSensor(ColorMode.Color);
        ev3.Sensor4 = new GyroSensor(GyroMode.Angle);
        ConsoleKeyInfo cki;
        Console.WriteLine("Press Q to quit");
        do
        {
            cki = Console.ReadKey(true); //press a key
            switch (cki.Key) {
                case ConsoleKey.D1://1 is pressed
                    Console.WriteLine("S1: " + ev3.Sensor1.ReadAsString());
                    break;
                case ConsoleKey.D2://2 is pressed
                    Console.WriteLine("S2: " + ev3.Sensor2.ReadAsString());
                    break;
                case ConsoleKey.D3://3 is pressed
                    Console.WriteLine("S3: " + ev3.Sensor3.ReadAsString());
                    break;
                case ConsoleKey.D4://4 is pressed
                    Console.WriteLine("S4: " + ev3.Sensor4.ReadAsString());
                    break;
            }
        } while (cki.Key != ConsoleKey.Q);
        ev3.Connection.Close();
    }
}
```

#### Встановлення типу давача

Використовуючи фрейворк, можна отримати доступ до певних функцій датчика, як показано в наведеному нижче прикладі. Тут сенсорний датчик розраховує натискань, і його можна очистити, натиснувши R. Значення кольору оцінюється, щоб визначити, чи дійсно колір є зеленим, і, нарешті, IR-Sensor використовується в режимі пошуку, щоб знайти пульт дистанційного керування. Режим пошуку ІК працює лише на каналі 0.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<TouchSensor, ColorSensor, IRSensor, Sensor>("usb");
        ev3.Connection.Open();
        ev3.Sensor1.Mode = TouchMode.Count;
        ev3.Sensor2.Mode = ColorMode.Color;
        ev3.Sensor3.Mode = IRMode.Seek;
        ConsoleKeyInfo cki;
        Console.WriteLine("Press Q to quit");
        do
        {
            cki = Console.ReadKey(true); //press a key
            switch (cki.Key) {
                case ConsoleKey.R://C is pressed
                    ev3.Sensor1.Reset();//reset the count
                    Console.WriteLine("Reset touch count");
                    break;
                case ConsoleKey.D1://1 is pressed
                    Console.WriteLine("S1: " + ev3.Sensor1.ReadAsString());
                    break;
                case ConsoleKey.D2://2 is pressed
                    Color color = ev3.Sensor2.ReadColor();
                    if (color == Color.Green) {
                        Console.WriteLine("Color is green");
                        ev3.Beep(50, 100);
                    }
                    else {
                        Console.WriteLine("Color is " + color + " and this is not green");
                    }
                    break;
                case ConsoleKey.D3://3 is pressed
                    int value = ev3.Sensor3.Read();
                    if (value == 0) {
                        ev3.Beep(50, 100);
                        Console.WriteLine("Found target");
                    }
                    else {
                        if (value < 0) {
                            Console.WriteLine("Target is to the left");
                        }
                        else {
                            Console.WriteLine("Target is to the right");
                        }
                    }
                    break;
            }
        } while (cki.Key != ConsoleKey.Q);
        ev3.Connection.Close();
    }
}
```

#### Автоматичне виявлення типу давача

Наступний приклад показує, як автоматично визначати тип датчика та призначити датчик правильному типу. Це дає можливість друкувати значення у правильному форматі.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        ev3.Connection.Open();
        Sensor newSensor = null;
        string key =
        SensorHelper.TypeToKey(ev3.Sensor1.GetSensorType());
        if (SensorHelper.SensorDictionary.TryGetValue(key, out newSensor)) {
            ev3.Sensor1 = newSensor;
        }
        ConsoleKeyInfo cki;
        Console.WriteLine("Press Q to quit");
        do
        {
            cki = Console.ReadKey(true); //press a key
            switch (cki.Key) {
                case ConsoleKey.D1://1 is pressed
                    Console.WriteLine("S1: " + ev3.Sensor1.ReadAsString());
                    break;
            }
        } while (cki.Key != ConsoleKey.Q);
        ev3.Connection.Close();
    }
}
```

#### Використання файлової системи

За допомогою файлової системи можна запускати та зупиняти програми, отримувати список файлів і відтворювати звукові файли. Нижче наведено деякі зразки коду для позначення підтеків та файлів у папці проекту.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        ev3.Connection.Open();
        BrickFile[] files;
        string[] subfolders;
        ev3.FileSystem.GetFolderInfo("/home/root/lms2012/prjs/", out files, out subfolders);
        Console.WriteLine("Files:");
        foreach(var file in files) {
            Console.WriteLine(file.Name);
        }
        Console.WriteLine(Environment.NewLine + "Subfolders:");
        foreach(var folder in subfolders) {
            Console.WriteLine(folder);
        }
        ev3.Connection.Close();
    }
}
```

#### Створення директорії та запис файлу в EV3

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
ev3.Connection.Open();
ev3.FileSystem.CreateDirectory("/home/root/lms2018/prjs/MyPrograms");
ev3.FileSystem.WriteFile(@"C:\program.rbf", "/home/root/lms2018/prjs/MyPrograms/program.rbf");
ev3.Connection.Close();
```

#### Рекурсивно виведення файлів програм, що знаходяться в / home або його вкладені папки

Цей приклад вимагає включення linq у проект. У Visual Studio це за умовчанням, тоді як Mono Users повинні буде додати посилання на System.Core

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
ev3.Connection.Open();
var folderStructure = ev3.FileSystem.GetFolderStructure("/home");
var fileQuery = from structure in folderStructure.RunThroughFolders()
from files in structure.FileList
where files.FileType == MonoBrick.FileType.Program
select files;
foreach(var file in fileQuery)
    Console.WriteLine(file.Name + " in " + file.Path);
ev3.Connection.Close();
```

#### Запуск та зупинка першої програми, що знаходиться в / home або її підпапках

Цей приклад вимагає включення linq у проект. У Visual Studio це за умовчанням, тоді як Mono Users повинні буде додати посилання на System.Core

```csharp
var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
ev3.Connection.Open();
var folderStructure = ev3.FileSystem.GetFolderStructure("/home");
var fileQuery = from structure in folderStructure.RunThroughFolders()
from files in structure.FileList
where files.FileType == MonoBrick.FileType.Program
select files;
ev3.StartProgram(fileQuery.First());
System.Threading.Thread.Sleep(5000);
ev3.StopProgram();
ev3.Connection.Close();
```

#### Надсилання даних до поштової скриньки

Для того, щоб отримувати дані з поштову скриньку EV3, програма повинна працювати на блоці, який прослуховує дані з поштової скриньки. Використовуйте посилання для завантаження, щоб затримати програму EV3, показану нижче. Програма просто приймає рядок введення з поштової скриньки з назвою "mailbox1" і друкує його на дисплеї.

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        ev3.Connection.Open();
        ConsoleKeyInfo cki;
        Console.WriteLine("Press Q to quit");
        do
        {
            cki = Console.ReadKey(true); //press a key
            switch (cki.Key) {
                case ConsoleKey.M:
                    Console.WriteLine("String to send to mailbox");
                    string input = Console.ReadLine();
                    ev3.Mailbox.Send("mailbox1", input, false);
                    break;
            }
        } while (cki.Key != ConsoleKey.Q);
        ev3.Connection.Close();
    }
}
```

#### Контроль блоків, під’єднаних послідовно

```csharp
using System;
using MonoBrick.EV3;
using System.Threading;
public static class Program {
    static void Main(string[] args)
    {
        var ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>("usb");
        ev3.Connection.Open();
        ev3.MotorA.DaisyChainLayer = DaisyChainLayer.First;
        ev3.MotorA.On(50);
        Thread.Sleep(2000);
        ev3.MotorA.Off();
        ev3.Sensor1.DaisyChainLayer = DaisyChainLayer.Second;
        Console.WriteLine(ev3.Sensor1.ReadAsString());
        ev3.Connection.Close();
    }
}
```

### Використання комунікаційної бібліотеки MonoBrick у Windows

Розглянемо встановлення зв'язку USB та Bluetooth між блоком LEGO Mindstorms та операційною системою Windows для використання з бібліотекою зв'язку MonoBrick.

#### USB-зв'язок

Для спілкування з EV3 бібліотека комунікацій MonoBrick використовує HID API, тому, якщо ви використовуєте бібліотеку для розробки, вам потрібно помістити hipapi.dll у завантажувану бібліотеку зв'язку MonoBrick у тій самій папці, що й exe-файл. Щоб отримати USB-зв'язок для роботи під керуванням Windows за допомогою EV3, потрібно виконати два кроки, якщо ви не встановили програмне забезпечення EV3.

1. Завантажте драйвер fantom з веб-сайту LEGO
2. Встановіть драйвер. Завантажте файл LibUsbDotNet.dll, який постачається разом із бібліотекою комунікацій MonoBrick, у той же папці, що й файл exe, який ви хочете запустити.

#### Bluetooth зв'язок

Для зв'язку з LEGO Mindstorms Brick через Bluetooth необхідно встановити партнерство між Windows і блоком. Для цього потрібні наступні п'ять кроків

1. Знайдіть новий Bluetooth-пристрій
2. Підключіться до блоку EV3
3. Введіть код 1234 як код з'єднання на EV3
4. Введіть 1234 як код пару на ПК
5. Зачекайте, поки спарювання буде встановлено
6. Після виконання цих кроків ви повинні мати можливість спілкуватися з блоком за допомогою Bluetooth.

### Firmware

The MonoBrick EV3 firmware is a firmware replacement that allows you to program and debug the EV3 brick using the open source .Net framework called Mono. This let’s you program the EV3 in .Net compatible languages such as C#, F# and IronPython. Since the firmware fits on a single SD card you simply boot the MonoBrick firmware directly from the SD card without replacing the standard firmware.

As programs are executed on the Mono Framework programs can be written/compiled on Windows, Linux or Mac OS using either Xamarin Studio or Microsoft Visual Studio. The firmware supports all the features listed below.

- Support for all Retail and Educational LEGO sensors – Example
- Support for a number of HiTechnic sensors – Example
- Motor support including speed, timer and power profiles – Example
- Motor PID position controller – Example
- Motor synchronisation – Example
- Vehicle support - Example
- Draw graphics on the LCD - Example
- Write text to LCD including support for custom fonts - Example
- LCD Screenshot dump to BMP file - Example
- Build in Menu and Dialog support – Example
- Detect when sensors are attached/detached – Example
- SQLite support – Example
- Button event support
- Button LED support
- USB support
- Easy to use UART, I2C and analog sensor base classes
- Automatic firmware updates over the internet
- and more..

### Прошивка MonoBrick EV3

Прошивка MonoBrick EV3 - це заміна прошивки, яка дозволяє програмувати та налагоджувати цеглину EV3 за допомогою відкритого коду .Net під назвою Mono. Це дозволить програмувати EV3 в. Сумісних мовах, таких як C#, F# та IronPython. Оскільки прошивка підходить для однієї SD-карти, просто завантажується прошивка MonoBrick безпосередньо з SD-карти, не замінюючи стандартну прошивку.

Оскільки програми, що виконуються в програмах Mono Framework, можуть бути написані / скомпільовані на Windows, Linux або Mac OS, використовуючи Xamarin Studio або Microsoft Visual Studio.

#### Початок роботи

Це досить легко почати з прошивки MonoBrick. Все, що потрібно зробити, це виконати такі кроки:

- Створіть завантажуване зображення за допомогою посібника Windows або довідника Mac OS / Linux
- Встановити драйвер USB за цим посібником або встановити з'єднання Wi-Fi
- Встановіть вбудоване прошивання Xamarin Studio MonoBrick для завантаження та налагодження програм.

#### Приклад Програми

Нижче показано програму зразка для датчика кольору. Програма дозволить вибрати різні режими кольорів і роздрукувати значення сенсора на дисплеї.

```csharp
using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Sensors;
using MonoBrickFirmware.UserInput;
using System.Threading;
namespace ColorSensorExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EventWaitHandle stopped = new ManualResetEvent(false);
            ColorMode[] modes = { ColorMode.Color, ColorMode.Reflection, ColorMode.Ambient, ColorMode.Blue };
            int modeIdx = 0;
            var sensor = new EV3ColorSensor(SensorPort.In1);
            ButtonEvents buts = new ButtonEvents();
            buts.EscapePressed += () => {
                stopped.Set();
            };
            buts.UpPressed += () => {
                LcdConsole.WriteLine("Sensor value: " + sensor.ReadAsString());
            };
            buts.DownPressed += () => {
                LcdConsole.WriteLine("Raw sensor value: " + sensor.ReadRaw());
            };
            buts.EnterPressed += () => {
                modeIdx = (modeIdx + 1) % modes.Length;
                sensor.Mode = modes[modeIdx];
                LcdConsole.WriteLine("Sensor mode is: " + modes[modeIdx]);
            };
            stopped.WaitOne();
        }
    }
}
```

#### Приклад. Підтримка усіх давачів LEGO

```csharp
using System;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Sensors;
using System.Threading;
namespace IRSensorExample {
    class MainClass {
        public static void Main(string[] args) {
            IRChannel[] channels = { IRChannel.One, IRChannel.Two, IRChannel.Three, IRChannel.Four };
            int channelIdx = 0;
            ManualResetEvent terminateProgram = new ManualResetEvent(false);
            var sensor = new EV3IRSensor(SensorPort.In1);
            ButtonEvents buts = new ButtonEvents();
            LcdConsole.WriteLine("Use IR on port1");
            LcdConsole.WriteLine("Up distance");
            LcdConsole.WriteLine("Down beacon location");
            LcdConsole.WriteLine("Enter read command");
            LcdConsole.WriteLine("Left change channel");
            LcdConsole.WriteLine("Right read as string");
            LcdConsole.WriteLine("Esc. terminate");
            buts.EscapePressed += () => {
                terminateProgram.Set();
            };
            buts.UpPressed += () => {
                LcdConsole.WriteLine("Distance " + sensor.ReadDistance() + " cm");
            };
            buts.EnterPressed += () => {
                LcdConsole.WriteLine("Remote command " + sensor.ReadRemoteCommand() + " on channel " + sensor.Channel); };
            buts.DownPressed += () => {
                BeaconLocation location = sensor.ReadBeaconLocation();
                LcdConsole.WriteLine("Beacon location: " + location.Location + " Beacon distance: " + location.Distance + " cm");
            };
            buts.LeftPressed += () => {
                channelIdx = (channelIdx + 1) % channels.Length;
                sensor.Channel = channels[channelIdx];
                LcdConsole.WriteLine("Channel is set to: " + channels[channelIdx]);
            };
            buts.RightPressed += () => {
                LcdConsole.WriteLine(sensor.ReadAsString());
            };
            terminateProgram.WaitOne();
        }
    }
}
```

#### Приклад. Підтримка давачів HiTechnic

```csharp
using System;
using System.Threading;
using System.Collections.Generic;
using System.Resources;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Sensors;
namespace HiTechnicI2CExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ManualResetEvent terminateProgram = new ManualResetEvent(false);
            ButtonEvents buts = new ButtonEvents();
            HiTecCompassSensor compass = new HiTecCompassSensor(SensorPort.In1);
            HiTecColorSensor colorSensor = new HiTecColorSensor(SensorPort.In2);
            HiTecTiltSensor tilt = new HiTecTiltSensor(SensorPort.In3);
            LcdConsole.WriteLine("Use compass on port1");
            LcdConsole.WriteLine("Use color on port2");
            LcdConsole.WriteLine("Use tilt on port3");
            LcdConsole.WriteLine("Up read compass");
            LcdConsole.WriteLine("Down read tilt");
            LcdConsole.WriteLine("Enter read color");
            LcdConsole.WriteLine("Esc. terminate");
            buts.EscapePressed += () => {
                terminateProgram.Set();
            };
            buts.UpPressed += () => {
                LcdConsole.WriteLine("Compass sensor: " + compass.ReadAsString());
            };
            buts.EnterPressed += () => {
                LcdConsole.WriteLine("Color sensor: " + colorSensor.ReadAsString());
                LcdConsole.WriteLine("Color index: " + colorSensor.ReadColorIndex());
            };
            buts.DownPressed += () => {
                LcdConsole.WriteLine("Tilt : " + tilt.ReadAsString());
            };
            terminateProgram.WaitOne();
        }
    }
}
```

#### Приклад. Підтпримка профілів встановлення швидкості часу та потужності двигунів

```csharp
using System;
using System.Threading;
using MonoBrickFirmware;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
namespace MotorExample {
    class MainClass {
        public static void Main(string[] args)
        {
            Motor motorA = new Motor(MotorPort.OutA);
            Motor motorD = new Motor(MotorPort.OutD);
            WaitHandle motorWaitHandle;
            motorA.Off();
            motorD.Off();
            //Power control
            LcdConsole.WriteLine("Set power to 50");
            motorA.SetPower(50);
            Thread.Sleep(3000);
            LcdConsole.WriteLine("Break");
            motorA.Brake();
            //Speed control
            LcdConsole.WriteLine("Set speed to 50");
            motorA.SetSpeed(50);
            Thread.Sleep(1000);
            LcdConsole.WriteLine("Speed: " + motorA.GetSpeed());
            Thread.Sleep(2000);
            LcdConsole.WriteLine("Break");
            motorA.Brake();
            //Position control of single motor
            Thread.Sleep(3000);
            motorA.ResetTacho();
            LcdConsole.WriteLine("Moving motor A to 2000 ");
            motorWaitHandle = motorA.SpeedProfile(50, 200, 1600, 200, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for motor A to stop");
            motorWaitHandle.WaitOne();
            LcdConsole.WriteLine("Done moving motor");
            LcdConsole.WriteLine("Position A: "+motorA.GetTachoCount());
            //Individual position control of both motors
            Thread.Sleep(3000);
            motorA.ResetTacho();
            motorD.ResetTacho();
            LcdConsole.WriteLine("Moving motors A to 2000");
            LcdConsole.WriteLine("Moving motor B to 1000");
            WaitHandle[] handles = new WaitHandle[2];
            handles[0] = motorA.SpeedProfile(50, 200, 1600, 200, true);
            handles[1] = motorD.SpeedProfile(50, 200, 600, 200, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for both motors to stop");
            WaitHandle.WaitAll(handles);
            LcdConsole.WriteLine("Done moving both motors");
            LcdConsole.WriteLine("Position A: " + motorA.GetTachoCount());
            LcdConsole.WriteLine("Position D: " + motorD.GetTachoCount());
            motorA.Off();
            motorD.Off();
            //Motor synchronisation position control
            Thread.Sleep(3000);
            motorA.ResetTacho();
            motorD.ResetTacho();
            MotorSync sync = new MotorSync(MotorPort.OutA, MotorPort.OutD);
            LcdConsole.WriteLine("Sync motors to move 3000 steps forward");
            motorWaitHandle = sync.StepSync(40, 0, 3000, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for sync to stop");
            motorWaitHandle.WaitOne();
            LcdConsole.WriteLine("Done sync moving both motors");
            LcdConsole.WriteLine("Position A: " + motorA.GetTachoCount());
            LcdConsole.WriteLine("Position D: " + motorD.GetTachoCount());
            sync.Off();
        }
    }
}
```

#### Приклад. Контроль позиції PID

```csharp
using System;
using System.Threading;
using MonoBrickFirmware;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
namespace PositionPIDExample
{
    class MainClass
    {
        private const float P = 4.8f;
        private const float I = 800.1f;
        private const float D = 8.5f;
        public static void Main(string[] args)
        {
            Motor motor = new Motor(MotorPort.OutA);
            motor.ResetTacho();
            PositionPID PID = new PositionPID(motor, 4000, true, 50, P, I, D, 5000);
            var waitHandle = PID.Run();
            LcdConsole.WriteLine("Moving motor A to position 4000");
            LcdConsole.WriteLine("Waiting for controller to finish");
            //Wait for controller to finish - you can do other stuff here
            waitHandle.WaitOne();
            LcdConsole.WriteLine("Done");
            LcdConsole.WriteLine("Motor position: " + motor.GetTachoCount());
        }
    }
}
```

#### Приклад. Синхронізація двигунів

```csharp
using System;
using System.Threading;
using MonoBrickFirmware;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
namespace MotorExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Motor motorA = new Motor(MotorPort.OutA);
            Motor motorD = new Motor(MotorPort.OutD);
            WaitHandle motorWaitHandle;
            motorA.Off();
            motorD.Off();
            //Power control
            LcdConsole.WriteLine("Set power to 50");
            motorA.SetPower(50);
            Thread.Sleep(3000);
            LcdConsole.WriteLine("Break");
            motorA.Brake();
            //Speed control
            LcdConsole.WriteLine("Set speed to 50");
            motorA.SetSpeed(50);
            Thread.Sleep(1000);
            LcdConsole.WriteLine("Speed: " + motorA.GetSpeed());
            Thread.Sleep(2000);
            LcdConsole.WriteLine("Break");
            motorA.Brake();
            //Position control of single motor
            Thread.Sleep(3000);
            motorA.ResetTacho();
            LcdConsole.WriteLine("Moving motor A to 2000 ");
            motorWaitHandle = motorA.SpeedProfile(50, 200, 1600, 200, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for motor A to stop");
            motorWaitHandle.WaitOne();
            LcdConsole.WriteLine("Done moving motor");
            LcdConsole.WriteLine("Position A: " + motorA.GetTachoCount());
            //Individual position control of both motors
            Thread.Sleep(3000);
            motorA.ResetTacho();
            motorD.ResetTacho();
            LcdConsole.WriteLine("Moving motors A to 2000");
            LcdConsole.WriteLine("Moving motor B to 1000");
            WaitHandle[] handles = new WaitHandle[2];
            handles[0] = motorA.SpeedProfile(50, 200, 1600, 200, true);
            handles[1] = motorD.SpeedProfile(50, 200, 600, 200, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for both motors to stop");
            WaitHandle.WaitAll(handles);
            LcdConsole.WriteLine("Done moving both motors");
            LcdConsole.WriteLine("Position A: " + motorA.GetTachoCount());
            LcdConsole.WriteLine("Position D: " + motorD.GetTachoCount());
            motorA.Off();
            motorD.Off();
            //Motor synchronisation position control
            Thread.Sleep(3000);
            motorA.ResetTacho();
            motorD.ResetTacho();
            MotorSync sync = new MotorSync(MotorPort.OutA, MotorPort.OutD);
            LcdConsole.WriteLine("Sync motors to move 3000 steps forward");
            motorWaitHandle = sync.StepSync(40, 0, 3000, true);
            //you could do something else here
            LcdConsole.WriteLine("Waiting for sync to stop");
            motorWaitHandle.WaitOne();
            LcdConsole.WriteLine("Done sync moving both motors");
            LcdConsole.WriteLine("Position A: " + motorA.GetTachoCount());
            LcdConsole.WriteLine("Position D: " + motorD.GetTachoCount());
            sync.Off();
        }
    }
}
```

#### Приклад. Підтримка платформ

```csharp
using System;
using System.Threading;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Movement;
namespace VehicleExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(MotorPort.OutA, MotorPort.OutD);
            WaitHandle waitHandle;
            const int speed = 40;
            const int moveSteps = 2000;//You need to adjust this
            const int spinSteps = 500;//You need to adjust this
            vehicle.ReverseLeft = false;//You might need to adjust this
            vehicle.ReverseRight = false;//You might need to adjust this
            LcdConsole.WriteLine("Use Motor on A");
            LcdConsole.WriteLine("Use Motor on D");
            //Make a square
            for (int i = 0; i < 4; i++) {
                LcdConsole.WriteLine("Spin left");
                waitHandle = vehicle.SpinLeft(speed, spinSteps, true);
                waitHandle.WaitOne();
                LcdConsole.WriteLine("Move forward");
                waitHandle = vehicle.Forward(speed, moveSteps, true);
                waitHandle.WaitOne();
            }
            vehicle.Off();
            Thread.Sleep(3000);
            LcdConsole.WriteLine("Make a soft turn to the left");
            waitHandle = vehicle.TurnLeftForward(speed, 50, moveSteps, false);
            waitHandle.WaitOne();
            LcdConsole.WriteLine("Make a soft turn to the left");
        }
    }
}
```

#### Приклад. Друк графіки на LCD

```csharp
using System;
using System.Threading;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
namespace LcdDraw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventWaitHandle stopped = new ManualResetEvent(false);
            int centerX = Lcd.Width / 2;
            int centerY = Lcd.Height / 2;
            Point center = new Point(centerX, centerY);
            int refreshRate = 100;
            bool run = true;
            ButtonEvents buts = new ButtonEvents();
            buts.EscapePressed += () => {
                stopped.Set();
                run = false;
            };
            while (run) {
                for (int k = 0; k < 4; k++) {
                    for (int i = 1; i < centerY; i++) {
                        Lcd.Clear();
                        Lcd.DrawCircle(center, (ushort)i, true, true);
                        Lcd.Update();
                        stopped.WaitOne(refreshRate);
                    }
                    for (int i = centerY - 1; i > 0; i--) {
                        Lcd.Clear();
                        Lcd.DrawCircle(center, (ushort)i, true, true);
                        Lcd.Update();
                        stopped.WaitOne(refreshRate);
                    }
                }
                for (int k = 0; k < 20; k++) {
                    Lcd.Clear();
                    Lcd.DrawHLine(center, centerX / 2, true);
                    stopped.WaitOne(refreshRate);
                    Lcd.Clear();
                    Lcd.DrawVLine(center, centerY / 2, true);
                }
            }
        }
    }
}
```

#### Приклад. Виявлення активації давачів

```csharp
using System;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Sensors;
using System.Threading;
namespace SensorFactoryExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            object sensorLock = new object();
            bool run = true;
            ISensor[] sensor = new ISensor[4];
            for (int i = 0; i < 4; i++)
            {
                sensor[i] = null;
            }
            using (SensorListner listner = new SensorListner())
            {
                listner.SensorAttached += delegate(ISensor obj)
                {
                    lock(sensorLock)
                    {
                        if (obj != null)
                        {
                            sensor[(int)obj.Port] = obj;
                        }
                    }
                };
                listner.SensorDetached += delegate(SensorPort obj)
                {
                    lock(sensorLock)
                    {
                        sensor[(int)obj] = null;
                    }
                };
                ButtonEvents buts = new ButtonEvents();
                buts.EscapePressed += delegate
                {
                    run = false;
                };
                while (run)
                {
                    lock(sensorLock)
                    {
                        for (int i = 0; i < sensor.Length; i++) {
                            if (sensor[i] != null) {
                                typeLabel [i].Text = sensor[i].GetSensorName ();
                                modeLabel [i].Text = sensor[i].SelectedMode ();
                                valueLabel[i].Text = sensor[i].ReadAsString ();
                            } else {
                                typeLabel [i].Text = "Not connected";
                                modeLabel [i].Text = "-";
                                valueLabel [i].Text = "-";
                            }
                        }*/
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
```

## LEGO MINDSTORMS EV3 BRAIN_PEEK API for .NET

Традиційні роботи, побудовані на платформі Lego Mindstorms EV3, програмуються з використанням графічного середовища LabVIEW. В цьому випадку програми запускаються на контролері EV3 і робот працює автономно. Альтернативний спосіб управління роботом - використання платформи .NET, запущеної на комп'ютері для:

- віддаленого управління роботом з ноутбука (наприклад, після натискання кнопок).
- збору даних з контролера EV3 і обробляти їх на зовнішній системі (наприклад, для IoT-систем)
- інших ситуацій, коли хочеться написати алгоритм управління на .NET і запускати його з комп'ютера, підключеного до контролера EV3

### LEGO MINDSTORMS EV3 API for .NET

Управління контролером EV3 з зовнішньої системи здійснюється шляхом відправки команд в послідовний порт. Сам формат команд описаний в Communication Developer Kit.

Можна скористатися готовою .NET-обгорткою Brian Peek. Тексти програм цієї бібліотеки розміщені на Github, а готовий до використання пакет можна знайти в Nuget.

#### Підключення до контролера EV3

Для зв'язку з контролером EV3 використовується клас Brick. При створенні цього об'єкта в конструктор потрібно передати реалізацію інтерфейсу ICommunication - об'єкт, що описує спосіб підключення до контролера EV3. Доступні реалізації UsbCommunication, BluetoothCommunication і NetworkCommunication (підключення через WiFi).

Найбільш популярний спосіб підключення - через Bluetooth. Розглянемо детальніше цей спосіб підключення.

Перш ніж ми зможемо програмно підключитися до контролера через Bluetooth, контролер необхідно підключити до комп'ютера, використовуючи налаштування операційної системи.

Після того, як контролер підключений, переходимо в настройки Bluetooth і вибираємо вкладку COM-порти. Знаходимо наш контролер, нам потрібен вихідний порт. Його і будемо вказувати при створенні об'єкта BluetoothCommunication.

Код для підключення до контролера буде виглядати так:

```csharp
public async Task Connect(ICommunication communication)
{
    var communication = new BluetoothCommunication("COM9");
    var brick = _brick = new Brick(communication);
    await _brick.ConnectAsync();
}
```

Опціонально можна вказати таймаут підключення до контролера:

```csharp
await _brick.ConnectAsync(TimeSpan.FromSeconds(5));
```

Підключення до блоку через USB або WiFi здійснюється аналогічно, за тим винятком, що використовуються об'єкти UsbCommunication і NetworkCommunication.

Всі подальші дії, що виконуються з контролером, здійснюються через об'єкт Brick.

Покрутимо двигунами. Для виконання команд на контролері EV3 звернемося до властивості DirectCommand об'єкта Brick. Для початку спробуємо запустити мотори.

Припустимо, що наш мотор підключений до порту A контролера, тоді запуск цього мотора на потужності 50% буде виглядати так:

```csharp
await _brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 50);
```

Є й інші методи для управління мотором. Наприклад, можна повернути мотор на заданий кут, використовуючи методи `StepMotorAtPowerAsync()` і `StepMotorAtSpeedAsync()`. Усього доступно кілька методів, які є варіаціями на режими включення моторів - за часом, швидкості, потужності і т.д.

Примусова зупинка здійснюється методом `StopMotorAsync()`:

```csharp
await _brick.DirectCommand.StopMotorAsync(OutputPort.A, true);
```

Другий параметр вказує на використання гальма. Якщо його встановити в false, то мотор буде зупинятися «накатом».

#### Читання значень з давачів

Контролер EV3 має чотири порти для підключення сенсорів. Додатково до цього, мотори також мають вбудовані енкодери, що дозволяє використовувати їх як сенсори. У підсумку ми маємо 8 портів, з яких можна зчитувати значення.

Доступ до портів для зчитування значень можна отримати через властивість Ports об'єкта Brick. Ports - це колекція портів, доступних на контролері. Тому для роботи з конкретним портом потрібно його вибрати. InputPort.One ... InputPort.Four - це порти для датчиків, а InputPort.A ... InputPort.D - це енкодери моторів.

```csharp
var port1 = _brick.Ports[InputPort.One];
```

Датчики в EV3 можуть працювати в різних режимах. Наприклад, датчик кольору EV3 можна використовувати для вимірювання зовнішнього освітлення, вимірювання відбитого світла або для визначення кольору. Тому, щоб «повідомити» сенсора про те, як саме ми хочемо його використовувати, потрібно задати його режим:

```csharp
_brick.Ports[InputPort.One].SetMode(ColorMode.Reflective);
```

Тепер, коли датчик підключений і режим його роботи заданий, можна вважати з нього дані. Отримати можна «сирі» дані, оброблене значення і значення у відсотках.

```csharp
float si = _brick.Ports[InputPort.One].SIValue;
int raw = _brick.Ports[InputPort.One].RawValue;
byte percent = _brick.Ports[InputPort.One].PercentValue;
```

Властивість SIValue повертає оброблені дані. Тут все залежить від того, який саме датчик використовується і в якому режимі. Наприклад, при вимірі відбитого світла ми отримаємо значення від 0 до 100 в залежності від інтенсивності відбитого світла (чорний / білий).

Властивість RawValue повертає «сире» значення, отримане з АЦП. Іноді зручніше використовувати саме його для подальшої обробки та використання. До речі, в середовищі розробки EV3 теж є можливість отримання «сирих» значень - для цього потрібно скористатися блоком з синьою панелі.

Якщо використовуваний датчик призів будуть значень у відсотках, то можна також скористатися властивістю PercentValue.

#### Виконання команд «пачкою»

Припустимо, в нашому розпорядженні є робот-візок з двома колесами і ми хочемо розгорнути його на місці. У цьому випадку два колеса повинні обертатися в протилежному напрямку. Якщо ми скористаємося DirectCommand і послідовно відправимо дві команди контролеру, між їх виконанням може пройти деякий час:

```csharp
await _brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 50);
await _brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.B, -50);
```

У цьому прикладі ми відправляємо команду для обертання мотора A на швидкості 50, після успішного закінчення відправки цієї команди, повторюємо те ж саме з мотором, підключеним до порту B. Проблема в тому, що відправка команд відбувається не моментально, тому мотори можуть почати крутитися в різний час - поки передається команда для порту B, мотора A вже почне крутитися.

Якщо для нас критично важливо змусити крутиться мотори одночасно, можна відправляти команди контролеру «пачкою». В цьому випадку слід скористатися властивістю BatchCommand замість DirectCommand:

```csharp
_brick.BatchCommand.TurnMotorAtPower(OutputPort.A, 50);
_brick.BatchCommand.TurnMotorAtPower(OutputPort.B, -50);
await _brick.BatchCommand.SendCommandAsync();
```

Тепер готується відразу дві команди, після чого вони відправляються на контролер одним пакетом. Контролер, отримавши ці команди, почне обертання моторів одночасно.

Крім обертання моторів і зчитування значень сенсорів, можна виконувати ще ряд дій на контролері EV3. Не буду детально останаліваться на Кадом з них, перерахую тільки список того, що можна зробити: `CleanUIAsync()`, `DrawTextAsync()`, `DrawLineAsync()` і ін. - маніпуляція вбудованим екраном контролера EV3 `PlayToneAsync()` і `PlaySoundAsync()` - використання вбудованого динаміка для відтворення звуків `WriteFileAsync()`, `CopyFileAsync()`, `DeleteFileAsync()` (з SystemCommand) - робота з файлами

## ЗАВДАННЯ ДО ЛАБОРАТОРНОЇ РОБОТИ №5-8

### Перший рівень

1. Засобами фреймворку BrainPeek запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.
2. Засобами фреймворку MonoBreak запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.

### Другий рівень

1. Засобами фреймворку BrainPeek запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.
2. Засобами фреймворку MonoBreak запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.

### Третій рівень

1. Засобами фреймворку BrainPeek запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.
2. Засобами фреймворку MonoBreak запрограмувати робототехнічну систему згідно завдань до Лабораторних робіт 1-4.

### Контрольні питання

1. Вкажіть технічні можливостями фреймворку BrainPeek.
2. Особливості фреймворку BrainPeek для програмування роботів.
3. Особливості отримання та обробки інформацію, отриманої з давачів за допомогою фреймворку BrainPeek.
4. Особливості роботи з моторам робота за допомогою фреймворку BrainPeek.
5. Давачі роботизованих систем за допомогою фреймворку BrainPeek.
6. Особливості взаємодії давачів за допомогою фреймворку BrainPeek.
7. Принципи роботи ультразвукового давача за допомогою фреймворку BrainPeek.
8. Принципи роботи давача кольору за допомогою фреймворку BrainPeek.
9. Принципи роботи давача дотику. за допомогою фреймворку BrainPeek.
10. Базові завдання робототехнік.

Література: [9 c. 66; 10, c.29].
