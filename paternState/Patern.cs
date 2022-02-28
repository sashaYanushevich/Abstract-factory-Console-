using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternState
{

    class Study
    {
        public IStudyState State { get; set; }

        public Study(IStudyState ws)
        {
            State = ws;
        }

        public void Issued()
        {
            State.Issued(this);
        }
        public void Done()
        {
            State.Done(this);
        }
        public void MarkIsWorth()
        {
            State.MarkIsWorth(this);
        }
        public void MarkIsNotWorth()
        {
            State.MarkIsNotWorth(this);
        }
        public void Check()
        {
            State.Check(this);
        }
    }

    interface IStudyState
    {
        void Issued(Study study); //выдано
        void Done(Study study); // сделано
        void MarkIsWorth(Study study); // оценка поставлена
        void MarkIsNotWorth(Study study); // оценка не поставлена
        void Check(Study study); // сдать на проверку
    }

    class StudyIssued : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Задание выдано.");
            study.State = new StudyDone();
        }

        public void Done(Study study)
        {
            Console.WriteLine("Задание только выдано.");
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Нет ещё оценки.");
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Нет ещё оценки.");
        }
        public void Check(Study study)
        {
            Console.WriteLine("Только выдано.");
        }
    }
    class StudyDone : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Выдаём задание.");
            study.State = new StudyIssued();
        }
        public void Done(Study study)
        {
            Console.WriteLine("Задание выполнено.");
            study.State = new StudyPassedToCheck();
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Проверяется");
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Проверяется");
        }
        public void Check(Study study)
        {
            Console.WriteLine("Проверяется");
        }


    }
    class StudyPassedToCheck : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Выдаём задание.");
            study.State = new StudyIssued();
        }
        public void Done(Study study)
        {
            Console.WriteLine("Задание выполнено.");
            study.State = new StudyPassedToCheck();
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Проверяется");
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Проверяется");
        }
        public void Check(Study study)
        {
            Console.WriteLine("Отправлено на проверку");
            study.State = new StudyChecked();
        }
    }
    class StudyChecked : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Выдаём задание.");
            study.State = new StudyIssued();
        }
        public void Done(Study study)
        {
            Console.WriteLine("Задание выполнено.");
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Оценка поставлена");
            study.State = new StudyDone();
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Не выполнено.");
            study.State = new StudyNotDone();
        }
        public void Check(Study study)
        {
            Console.WriteLine("Проверено");
        }

    }
    class StudyRepassedToCheck : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Задание выдано.");
        }
        public void Done(Study study)
        {
            Console.WriteLine("Задание выполнено.");
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Оценка поставлена");
            study.State = new StudyDone();
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Не выполнено");
            study.State = new StudyNotDone();
        }
        public void Check(Study study)
        {
            Console.WriteLine("Выполнено");
        }
    }
    class StudyNotDone : IStudyState
    {
        public void Issued(Study study)
        {
            Console.WriteLine("Выдаём задание.");
            study.State = new StudyIssued();
        }
        public void Done(Study study)
        {
            Console.WriteLine("Задание не выполнено.");
        }
        public void MarkIsWorth(Study study)
        {
            Console.WriteLine("Оценки нет");
        }
        public void MarkIsNotWorth(Study study)
        {
            Console.WriteLine("Пересдано на проверку.");
            study.State = new StudyRepassedToCheck();
        }
        public void Check(Study study)
        {
            Console.WriteLine("Не выполнено");
        }
    }
}


