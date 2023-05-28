using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaboratoryNumber_2_1_WinForms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
    static class DataBank
    {
        public static int[] massL1;
        public static int[] massL2;

        public static SingleLinkedList L1 = new SingleLinkedList();
        public static SingleLinkedList L2 = new SingleLinkedList();

        public static string logicTask = "";
        public static void PrintListBox(ListBox listbox)
        {
            L1.Print(listbox);
        }

        public static void DestroyL()
        {
            L1.Destroy();
            L2.Destroy();
        }
        public static void CreatMassL1(int[] dates)
        {
            massL1 = new int[dates.Length];
            for (int i = 0; i < dates.Length; i++) massL1[i] = dates[i];
            L1.Create2(massL1);
        }
        public static void CreatMassL2(int[] dates)
        {
            massL2 = new int[dates.Length];
            for (int i = 0; i < dates.Length; i++) massL2[i] = dates[i];
            L2.Create2(massL2);
        }
        public static void MergeListsElements(ListBox listbox)
        {
            SingleLinkedList mergedList = new SingleLinkedList();
            SingleLinkedList.MergeLists(L1, L2, listbox);
        }
        public static void AddElementesN(ListBox listbox, int number)
        {
            L1.InsertBeforeFirst(number);
        }
        public static void AddElementesK(ListBox listbox, int number)
        {
            L1.InsertAfterEnd(number);
        }
        public static void AddElementesR(int element, int number)
        {
            Node tmp = L1.Find(element);
            if (tmp != null) L1.InsertAfterRandom(tmp, number);
            else MessageBox.Show("Узел не Найден!!!");
        }
        public static void DelElementsN(ListBox listbox)
        {
            L1.DeleteBeforeFirst();
        }
        public static void DelElementsK(ListBox listbox)
        {
            L1.DeleteAfterEnd();
        }
        public static void DelElementsR(int element)
        {
            Node tmp = L1.Find(element);
            if (tmp != null) L1.DeleteRightElement(tmp);
            else MessageBox.Show("Узел не Найден!!!");
        }
    }
    public class Node
    {
        private int info;
        private Node link;
        // Класс «Узел односвязного списка»
        // информационное поле узла
        // поле связи узла
        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        // свойства
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }

        public Node(int info) // конструкторы
        {
            Info = info;
        }
        public Node(int info, Node link)
        {
            Info = info; Link = link;
        }
    }

    public class SingleLinkedList// Класс «Односвязные списки»
    {
        private Node first; // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: инициализация пустого списка
        {
            first = null;
        }
        public static void MergeLists(SingleLinkedList list1, SingleLinkedList list2, ListBox listbox)
        {
            SingleLinkedList mergedList = new SingleLinkedList();
            Node current1 = list1.first;
            Node current2 = list2.first;

            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    mergedList.InsertAfterEnd(current1.Info);
                    current1 = current1.Link;
                }

                if (current2 != null)
                {
                    mergedList.InsertAfterEnd(current2.Info);
                    current2 = current2.Link;
                }
            }
            mergedList.Print(listbox);
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            { // first – ссылка на первый узел списка
              // data – значение информационного поля
              // узла списка
              // создание узла списка
              // заполнение инф. поля узла списка - data
                p.Link = first; // установка связи между вставленным узлом и списком
                first = p; // новое значение ссылки на первый узел
            }
        }
        public void InsertAfterEnd(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                }
                q.Link = p;
            }
        }
        public void InsertAfterRandom(Node p, int date)
        {
            Node q;
            if (p != null)
            {
                q = new Node(date);
                q.Link = p.Link;
                p.Link = q;
            }
        }
        public void DeleteBeforeFirst()
        {
            if (first != null) first = first.Link;
        }
        public void DeleteAfterEnd()
        {
            if (first != null)
            {
                int count = 0;
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                    count++;
                }
                int countS = 0;
                Node p = first;
                while (p.Link != null && countS < count - 1)
                {
                    p = p.Link;
                    countS++;
                }
                DeleteRightElement(p);
                if(count == 0) first = first.Link;
            }
        }
        public void DeleteRandom()
        {
            if (first != null)
            {
                int count = 0;
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                    count++;
                }
                Random rnd = new Random();
                int countRnd = rnd.Next(1, count);
                int countS = 0;
                Node p = first;
                while (p.Link != null && countS < countRnd)
                {
                    p = p.Link;
                    countS++;
                }
                DeleteRightElement(p);
            }
        }
        public void DeleteRightElement(Node p)
        { // p – предварительно установленная ссылка
            if (first != null)
            {
                Node q; // q – ссылка на исключаемый узел
                if (p != null && p.Link != null) // сылка p действительно установлена?

                // ссылка p не указывает на последний узел в списке?
                {
                    q = p.Link; // установить ссылку q на узел, следующий за элементом p
                    p.Link = q.Link; // изменить поле связи узла, за которым выполняется исключение
                }
            }
        }

        public Node Find(int info)
        {
            Node p = first;
            while ((p != null) && (p.Info != info)) p = p.Link;
            return p;
        }
        public void Create(int[] mass)
        {
            first = null;
            for (int i = 0; i < mass.Length; i++)
            {
                Node p = new Node();
                p.Info = mass[i];
                p.Link = first;
                first = p;
            }
        }
        public void Create2(int[] dates)
        {
            Node p, last;
            if (dates.Length == 0) first = null;
            else
            {
                first = new Node(dates[0], null);
                last = first;
                for (int i = 1; i < dates.Length; i++)
                {
                    p = new Node(dates[i], null);
                    last.Link = p;
                    last = p;
                }
            }
        }
        public void Destroy()
        {
            first = null;
        }

        public void Print(ListBox listbox)
        {
            Node p = first;
            while (p != null)
            {
                int num = p.Info;
                listbox.Items.Add(num.ToString());
                p = p.Link;
            }
        }
    }
}
