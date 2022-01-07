# Техническое задание
## Паттерн Стратегия
Реализовать 2 набора стратегий.
1-й значение функции в заданной точке
стратегии:
1. x^2
2. 3x + 5
3. sqrt(x)
4. sin(x)
5. tg(x)

2-я стратегия работа с массивом, сгенерировать массив из 5 < n < 30 элементов из отрезка [1;5]
стртегии:
1. найти максимальный элемент
2. найти минимальный элемент
3. найти среднее значение
4. найти самй частый элемент

## Паттерн Шаблонный метод
Используя шаблонный метод реализавать описание машины
абстрактный класс здание:
Поля:
1. госномер
2. производитель

методы:
1. задать госномер
2. задать производителя
3. получить описание

В получить описание вывести общее описание: госномер и производитель, а так же вывести подробное
описание реализованое в наследниках.
Наследники:
1. легковой автомобиль
2. грузовой автомобиль
3. общественный транспорт

Наследник содержит как минимум одно уникальное поле задаваемое при инициализации и выводимое
в подробном описаниие.

## Паттерн Команда
Реализовать 2 класса наследника от раодительского класса:
1. Рабочий модуль.
2. Сетевой модуль.

В родительском классе обязательно указать абстрактный обработчик сообщений.
Разраобтать структуру сообщения содержащую:
сообщение (с произвольной структурой) (может быть указателем),
длинна сообщения (опционально в зависимости от определения сообщения),
ссылка на обратный вызов автора сообщения,
адресата,
Рабочий модуль раз в 2-3 секунды генерирует сообщения для сетевого модуля. Сетевой модуль
вызывает по окончании обработки функцию обратного вызова, рабочий проверяет ответ и
перепосылает запрос или генерирует новый с указанной паузой.

Все этапы:
1. Генерация сообщения.
2. Пересылка.
3. Обработка.
4. Вызов обратного вызова.

Писать в консольный лог с указанием времени и адреса текущего модуля.

## Паттерн фабричный метод и абстрактная фабрика
Реализовать "фабрику" с использованием фабричного метода реализующего работу основных
компонентов фабрики, для реализации и стандартизации структуры внутренних модулей фабрики
использовать паттерн абстрактная фабрика. <br/>
Реализовать фабрику по производству одежды 3-х типов (фабричный метод). Вся одежда имеет 2
параметра (например: ткань и размер) (абстрактная фабрика).
