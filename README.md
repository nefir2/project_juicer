1) Создать интерфейс Jucier (соковыжималка) с методом: void makeJuice(Fruit[] array)
2) Создать класс MyJucier, который реализовывает интерфейс Jucier; реализовать метод makeJuice в данном классе, который:
  2.1) Выводит информацию по каждому элементу массива
  2.2) Выводит общее количество фруктов, количество цитрусовых фруктов используемых для приготовления сока (экземпляров класса Citrus), выводит количество яблок (экземпляров класса Apple) используемых для приготовления сока.
3) Создать интерфейс Fruit, определить методы в данном интерфейсе:
  String getName(); // название фрукта
  Stirng getColor(); // цвет фрукта
  boolean isCitrus(); // является ли фрукт цитросувым фруктом
4) Создать абстрактые классы: Citrus, NonCitrus; реализовать метод boolean isCitrus() в данных классах.
5) Создать классы, которые наследуют класс Citrus или класс NonCitrus: Lemon, Orange, Banana, Apple
  Для каждого из классов определить свойства и методы.
  Для каждого из этих классов определить конструктор класса.
  Переопределить метод: public String toString() (класса Object) для вывода инофрмации по данному фрукту на экран
6) Проверить работу соковыжималки (MyJucier) в методе main - вызвать метода makeJuice с параметром метода (массив объектов типа Fruit)
