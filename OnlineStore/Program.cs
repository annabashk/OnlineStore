/// <summary>
/// Адрес
/// </summary>
abstract class Adress
{
    private string _sity;
    private string _street;
    private int _home;

    public string Sity
    { get { return _sity; } set { _sity = value; } }
    public string Street
    { get { return _street; } set { _street = value; } }
    public int Home
    { get { return _home; } 
        set 
        { 
            if (_home > 0)
            {
                _home = value;
            }
            else { Console.WriteLine("Номер дома не может быть отрицательным числом"); }
        } }
}

/// <summary>
/// Доставка
/// </summary>
abstract class Delivery : Adress
{
    
}

/// <summary>
/// Доставка на дом
/// </summary>
class HomeDelivery : Delivery
{

}

/// <summary>
/// Доставка в пункт выдачи
/// </summary>
class PickPointDelivery : Delivery
{

}

/// <summary>
/// Доставка в розничный магазин
/// </summary>
class ShopDelivery : Delivery
{

}

/// <summary>
/// Оплата
/// </summary>
abstract class Payment
{

}

/// <summary>
/// Оптата наличными
/// </summary>
class CashPayment : Payment
{

}

/// <summary>
/// Оплата картой
/// </summary>
class CardPayment : Payment
{

}

/// <summary>
/// Продукт
/// </summary>
class Product
{
    public string Name;
    public int Art;
}
class Order <TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayAddress()
    {
        Console.WriteLine();
    }
}