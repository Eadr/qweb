﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Infrastructure.QComands;

namespace WebUI.Infrastructure
{
    public interface IQCommand
    {
        QUploadFileHandler FileHandler { get; set; }            // Хранит путь к загруженномсу файлу, проверяет коректность данных в файле, удаляем его после выполнения команды
        QTaskHandler TaskHandler { get; set; }                  // Занимает, освобождает тадлицу под конкретную задачу
        string BorrowTable(string userLogin);                   // Проверяем свободна ли таблица, если да, то занимаем
        bool FillTable();                                       // заполняем темповую таблицу
        void Act();                                             // Выполнение конкретной задачи
        void ReleaseTable();                                    // Освобождаем таблицу
        event Action TaskFinishsed;                             // Извещает о завершении работы команды
    }
}