using System; // Импортируем пространство имен System для базовых функциональностей
using System.Collections.Generic; // Импортируем пространство имен Collections.Generic для использования обобщенных коллекций
using System.Linq; // Импортируем пространство имен LINQ для возможностей запросов
using System.Text; // Импортируем пространство имен Text для манипуляции строками
using System.Threading.Tasks; // Импортируем пространство имен Tasks для асинхронного программирования

namespace ClassLibrary1 // Определяем пространство имен для классов
{
    // Класс, представляющий запрос на ремонт
    public class RequestRemont
    {
        public int ID { get; private set; } // Уникальный идентификатор запроса
        public string Equipment { get; private set; } // Оборудование, связанное с запросом
        public string SerialNumber { get; private set; } // Серийный номер оборудования
        public string Description { get; private set; } // Описание проблемы
        public int ClientId { get; private set; } // Идентификатор клиента, сделавшего запрос
        public string Priority { get; private set; } // Уровень приоритета запроса
        public DateTime CreateAt { get; private set; } // Время создания запроса
        public DateTime UpdateAt { get; private set; } // Время последнего обновления запроса
        public DateTime FinishAt { get; private set; } // Время завершения запроса
        public string Status { get; private set; } // Текущий статус запроса

        // Конструктор для инициализации объекта RequestRemont
        public RequestRemont(int id, int ClientId)
        {
            ID = id; // Устанавливаем ID
            Equipment = string.Empty; // Инициализируем Equipment пустой строкой
            SerialNumber = string.Empty; // Инициализируем SerialNumber пустой строкой
            Description = string.Empty; // Инициализируем Description пустой строкой
            ClientId = ClientId; // Устанавливаем ClientId
            Priority = string.Empty; // Инициализируем Priority пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
            Status = string.Empty; // Инициализируем Status пустой строкой
        }
    }

    // Класс, представляющий запрос на регистрацию
    public class RequestRegistary
    {
        public int ID { get; private set; } // Уникальный идентификатор регистрационного запроса
        public string Priority { get; private set; } // Уровень приоритета регистрационного запроса
        public string SaveInformation { get; private set; } // Информация для сохранения
        public DateTime CreateAt { get; private set; } // Время создания регистрационного запроса
        public DateTime UpdateAt { get; private set; } // Время последнего обновления регистрационного запроса
        public DateTime FinishAt { get; private set; } // Время завершения регистрационного запроса

        // Конструктор для инициализации объекта RequestRegistary
        public RequestRegistary(int id)
        {
            ID = id; // Устанавливаем ID
            Priority = string.Empty; // Инициализируем Priority пустой строкой
            SaveInformation = string.Empty; // Инициализируем SaveInformation пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
        }
    }

    // Класс, представляющий запрос на обработку
    public class RequestProcessor
    {
        public int ID { get; private set; } // Уникальный идентификатор запроса на обработку
        public int ExecutorId { get; private set; } // Идентификатор исполнителя, работающего с запросом
        public string Priority { get; private set; } // Уровень приоритета запроса на обработку
        public string AdditionalInformation { get; private set; } // Дополнительная информация, связанная с запросом
        public DateTime CreateAt { get; private set; } // Время создания запроса на обработку
        public DateTime UpdateAt { get; private set; } // Время последнего обновления запроса на обработку
        public DateTime FinishAt { get; private set; } // Время завершения запроса на обработку

        // Конструктор для инициализации объекта RequestProcessor
        public RequestProcessor(int id, int ExecutorId)
        {
            ID = id; // Устанавливаем ID
            ExecutorId = ExecutorId; // Устанавливаем ExecutorId
            Priority = string.Empty; // Инициализируем Priority пустой строкой
            AdditionalInformation = string.Empty; // Инициализируем AdditionalInformation пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
        }
    }

    // Класс, представляющий запрос на выполнение
    public class RequestExecute
    {
        public int ID { get; private set; } // Уникальный идентификатор запроса на выполнение
        public int ExecutorId { get; private set; } // Идентификатор исполнителя, работающего с выполнением
        public string ChangesMade { get; private set; } // Изменения, внесенные в ходе выполнения
        public string OrderParts { get; private set; } // Запчасти, заказанные для выполнения
        public string CoordinationWork { get; private set; } // Координационные работы, связанные с выполнением
        public DateTime CreateAt { get; private set; } // Время создания запроса на выполнение
        public DateTime UpdateAt { get; private set; } // Время последнего обновления запроса на выполнение
        public DateTime FinishAt { get; private set; } // Время завершения запроса на выполнение

        // Конструктор для инициализации объекта RequestExecute
        public RequestExecute(int id, int ExecutorId)
        {
            ID = id; // Устанавливаем ID
            ExecutorId = ExecutorId; // Устанавливаем ExecutorId
            ChangesMade = string.Empty; // Инициализируем ChangesMade пустой строкой
            OrderParts = string.Empty; // Инициализируем OrderParts пустой строкой
            CoordinationWork = string.Empty; // Инициализируем CoordinationWork пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
        }
    }

    // Класс, представляющий отчет
    public class Report
    {
        public int ID { get; private set; } // Уникальный идентификатор отчета
        public int ExecutorId { get; private set; } // Идентификатор исполнителя, создавшего отчет
        public string Time { get; private set; } // Время, затраченное на задачу
        public string Materials { get; private set; } // Материалы, использованные в задаче
        public string Price { get; private set; } // Цена, связанная с задачей
        public string CauseMalfunction { get; private set; } // Причина неисправности
        public DateTime CreateAt { get; private set; } // Время создания отчета
        public DateTime UpdateAt { get; private set; } // Время последнего обновления отчета
        public DateTime FinishAt { get; private set; } // Время завершения отчета

        // Конструктор для инициализации объекта Report
        public Report(int id, int Executorid)
        {
            ID = id; // Устанавливаем ID
            ExecutorId = ExecutorId; // Устанавливаем ExecutorId
            Time = string.Empty; // Инициализируем Time пустой строкой
            Materials = string.Empty; // Инициализируем Materials пустой строкой
            Price = string.Empty; // Инициализируем Price пустой строкой
            CauseMalfunction = string.Empty; // Инициализируем CauseMalfunction пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
        }
    }

    // Класс, представляющий информацию о мониторинге
    public class Monitoring
    {
        public int ID { get; private set; } // Уникальный идентификатор записи мониторинга
        public string ProcessingTime { get; private set; } // Время, затраченное на обработку
        public string QuialityWork { get; private set; } // Качество выполненной работы
        public string Expenses { get; private set; } // Расходы, понесенные в процессе
        public DateTime CreateAt { get; private set; } // Время создания записи мониторинга
        public DateTime UpdateAt { get; private set; } // Время последнего обновления записи мониторинга
        public DateTime FinishAt { get; private set; } // Время завершения записи мониторинга

        // Конструктор для инициализации объекта Monitoring
        public Monitoring(int id)
        {
            ID = id; // Устанавливаем ID
            ProcessingTime = string.Empty; // Инициализируем ProcessingTime пустой строкой
            QuialityWork = string.Empty; // Инициализируем QuialityWork пустой строкой
            Expenses = string.Empty; // Инициализируем Expenses пустой строкой
            CreateAt = DateTime.MinValue; // Устанавливаем CreateAt в минимальное значение даты
            UpdateAt = DateTime.Now; // Устанавливаем UpdateAt на текущее время
            FinishAt = DateTime.MinValue; // Устанавливаем FinishAt в минимальное значение даты
        }
    }

    // Класс, представляющий клиента
    public class Client
    {
        public int ID { get; private set; } // Уникальный идентификатор клиента
        public string Name { get; private set; } // Имя клиента
        public string Surname { get; private set; } // Фамилия клиента
        public string Patronymic { get; private set; } // Отчество клиента

        // Конструктор для инициализации объекта Client
        public Client(int id)
        {
            ID = id; // Устанавливаем ID
            Name = string.Empty; // Инициализируем Name пустой строкой
            Surname = string.Empty; // Инициализируем Surname пустой строкой
            Patronymic = string.Empty; // Инициализируем Patronymic пустой строкой
        }
    }

    // Класс, представляющий исполнителя
    public class Executor
    {
        public int ID { get; private set; } // Уникальный идентификатор исполнителя
        public string Name { get; private set; } // Имя исполнителя
        public string Surname { get; private set; } // Фамилия исполнителя
        public string Patronymic { get; private set; } // Отчество исполнителя

        // Конструктор для инициализации объекта Executor
        public Executor(int id)
        {
            ID = id; // Устанавливаем ID
            Name = string.Empty; // Инициализируем Name пустой строкой
            Surname = string.Empty; // Инициализируем Surname пустой строкой
            Patronymic = string.Empty; // Инициализируем Patronymic пустой строкой
        }
    }
}
