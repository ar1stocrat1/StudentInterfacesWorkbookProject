using System;
using System.Collections.Generic;

// ==========================================================
// ПОШАГОВАЯ РАБОЧАЯ ТЕТРАДЬ ПО C#
// Тема: Интерфейсы в C#
// Формат: файл всегда компилируется, студент дописывает TODO
// ==========================================================
//
// КАК РАБОТАТЬ:
// 1. Запустите файл как есть.
// 2. Прочитайте пояснение преподавателя перед каждым шагом.
// 3. Найдите соответствующий TODO.
// 4. Замените заглушку на правильную реализацию.
// 5. Снова запустите программу и проверьте результат.
//
// ИДЕЯ УРОКА:
// Интерфейс описывает не то, КТО объект,
// а то, ЧТО объект умеет делать.
//
// ==========================================================

Console.WriteLine("Пошаговая рабочая тетрадь: Интерфейсы в C#");
Console.WriteLine(new string('=', 68));

TeacherIntro();
Step1_Movable();
Step2_Notifications();
Step3_MultipleInterfaces();
Step4_ExplicitImplementation();
FinalReflection();

// ----------------------------------------------------------
// ВСТУПЛЕНИЕ
// ----------------------------------------------------------
static void TeacherIntro()
{
    Console.WriteLine("\n[Вступление преподавателя]");
    Console.WriteLine("Сегодня мы разбираем интерфейсы в C#.");
    Console.WriteLine("Интерфейс задает контракт: если класс его реализует,");
    Console.WriteLine("он обязан предоставить нужное поведение.");
    Console.WriteLine("Мы начнем с простых примеров и дойдем до более практичных.");
}

// ----------------------------------------------------------
// ШАГ 1. ИНТЕРФЕЙС КАК КОНТРАКТ
// ----------------------------------------------------------
static void Step1_Movable()
{
    Console.WriteLine("\n================ ШАГ 1. IMovable ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Разные объекты могут уметь двигаться.");
    Console.WriteLine("Но при этом они не обязаны быть родственными классами.");
    Console.WriteLine("Интерфейс IMovable описывает общую способность Move().");

    List<IMovable> movables = new List<IMovable>
    {
        new Car(),
        new Person(),
        new Robot()
    };

    Console.WriteLine("\nРезультат:");
    foreach (IMovable movable in movables)
    {
        movable.Move();
    }

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите класс Robot и замените заглушку в Move() на осмысленную реализацию.");
}

// ----------------------------------------------------------
// ШАГ 2. ИНТЕРФЕЙСЫ В ПРАКТИКЕ
// ----------------------------------------------------------
static void Step2_Notifications()
{
    Console.WriteLine("\n================ ШАГ 2. Уведомления ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Интерфейсы особенно полезны, когда мы хотим");
    Console.WriteLine("подменять реализации без переписывания логики.");

    List<INotificationSender> senders = new List<INotificationSender>
    {
        new EmailSender(),
        new SmsSender()
    };

    Console.WriteLine("\nРезультат:");
    foreach (INotificationSender sender in senders)
    {
        sender.Send("Привет из интерфейса!");
    }

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите класс SmsSender и замените заглушку в Send() на правильную строку.");
}

// ----------------------------------------------------------
// ШАГ 3. НЕСКОЛЬКО ИНТЕРФЕЙСОВ
// ----------------------------------------------------------
static void Step3_MultipleInterfaces()
{
    Console.WriteLine("\n================ ШАГ 3. Несколько интерфейсов ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Один класс может реализовать сразу несколько интерфейсов.");
    Console.WriteLine("Это важно, потому что в C# нельзя наследоваться от двух классов,");
    Console.WriteLine("но можно поддерживать несколько ролей одновременно.");

    Message message = new Message("Интерфейсы делают архитектуру гибче.");

    Console.WriteLine("\nРезультат:");
    Console.WriteLine($"Текст сообщения: {message.Text}");
    message.Print();

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите метод Print() в классе Message и замените заглушку.");
}

// ----------------------------------------------------------
// ШАГ 4. ЯВНАЯ РЕАЛИЗАЦИЯ
// ----------------------------------------------------------
static void Step4_ExplicitImplementation()
{
    Console.WriteLine("\n================ ШАГ 4. Явная реализация интерфейса ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Иногда один класс реализует два интерфейса с одинаковым методом.");
    Console.WriteLine("Тогда можно реализовать эти методы явно, по-разному для каждого интерфейса.");

    Sample sample = new Sample();
    IControl control = sample;
    ISurface surface = sample;

    Console.WriteLine("\nРезультат:");
    control.Paint();
    surface.Paint();

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите реализацию ISurface.Paint() и замените заглушку.");
}

// ----------------------------------------------------------
// ИТОГ
// ----------------------------------------------------------
static void FinalReflection()
{
    Console.WriteLine("\n================ ИТОГ ================");
    Console.WriteLine("Проверьте себя:");
    Console.WriteLine("1. Что такое интерфейс?");
    Console.WriteLine("2. Чем интерфейс отличается от абстрактного класса?");
    Console.WriteLine("3. Почему один класс может реализовать несколько интерфейсов?");
    Console.WriteLine("4. Что дает программирование через интерфейс, а не через конкретный класс?");
    Console.WriteLine("5. В каких задачах интерфейсы особенно полезны?");
}

// ==========================================================
// БЛОК 1. БАЗОВЫЙ ИНТЕРФЕЙС
// ==========================================================
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }
}

class Person : IMovable
{
    public void Move()
    {
        Console.WriteLine("Человек идёт");
    }
}

class Robot : IMovable
{
    public void Move()
    {
        // TODO 1:
        // Замените заглушку на осмысленный текст о движении робота.
        Console.WriteLine("Робот движется на механических ногах");
    }
}

// ==========================================================
// БЛОК 2. ИНТЕРФЕЙСЫ В ПРАКТИКЕ
// ==========================================================
interface INotificationSender
{
    void Send(string message);
}

class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        // TODO 2:
        // Замените заглушку на правильный вывод SMS.
        Console.WriteLine($"SMS: {message}");
    }
}

// ==========================================================
// БЛОК 3. НЕСКОЛЬКО ИНТЕРФЕЙСОВ
// ==========================================================
interface IMessage
{
    string Text { get; set; }
}

interface IPrintable
{
    void Print();
}

class Message : IMessage, IPrintable
{
    public string Text { get; set; }

    public Message(string text)
    {
        Text = text;
    }

    public void Print()
    {
        // TODO 3:
        // Напечатайте Text в консоль.
        Console.WriteLine(Text);
    }
}

// ==========================================================
// БЛОК 4. ЯВНАЯ РЕАЛИЗАЦИЯ ИНТЕРФЕЙСОВ
// ==========================================================
interface IControl
{
    void Paint();
}

interface ISurface
{
    void Paint();
}

class Sample : IControl, ISurface
{
    void IControl.Paint()
    {
        Console.WriteLine("IControl.Paint");
    }

    void ISurface.Paint()
    {
        // TODO 4:
        // Замените заглушку на:
        // Console.WriteLine("ISurface.Paint");
        Console.WriteLine("ISurface.Paint");
    }
}

// ==========================================================
// ДОПОЛНИТЕЛЬНОЕ ТВОРЧЕСКОЕ ЗАДАНИЕ
// ==========================================================
//
// Создайте интерфейс IPlayable с методом Play().
// Затем создайте классы:
// - Guitar
// - Piano
// - Drum
//
// Реализуйте Play() по-разному в каждом классе.
// После этого создайте List<IPlayable> и вызовите Play() у каждого.
//
// ==========================================================
