const FirstPriceForOne = prompt("Ціна одиниці товару першого виду");
const SecondPriceForOne = prompt("Ціна одиниці товару другого виду");
const FirstQuantityOfGoods = prompt("Кількість товару першого виду");
const SecondQuantityOfGoods = prompt("Кількість товару другого виду");
const FirstPrice = FirstPriceForOne * FirstQuantityOfGoods;
const SecondPrice = SecondPriceForOne * SecondQuantityOfGoods;
alert("Ціна першого товару = "+FirstPrice)
alert("Ціна другого товару = "+SecondPrice)
alert("Загальна ціна = "+(FirstPrice+SecondPrice))