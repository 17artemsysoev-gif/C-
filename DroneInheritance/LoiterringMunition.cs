using System;

namespace DroneInheritance
{
    // 1. Наследование от AttackDrone через двоеточие
    public class LoiteringMunition : AttackDrone
    {
        // 2. Собственные новые свойства
        public double LoiterTime { get; set; }
        public string SeekerType { get; set; }

        // 3. Конструктор: принимает 8 параметров родителя + 2 новых
        public LoiteringMunition(string model, string manufacturer,
                                 double maxSpeed, double flightRange,
                                 double maxFlightTime, double takeoffWeight,
                                 double warheadWeight, string targetType,
                                 double loiterTime, string seekerType)
            // Передаём 8 параметров в конструктор AttackDrone
            : base(model, manufacturer, maxSpeed, flightRange, maxFlightTime, takeoffWeight, warheadWeight, targetType)
        {
            // Заполняем только 2 новых свойства
            LoiterTime = loiterTime;
            SeekerType = seekerType;
        }

        // 4. Собственный метод (использует и новые, и унаследованные свойства)
        public void LoiterAndStrike()
        {
            Console.WriteLine(
                $"{Model} барражирует в течение {LoiterTime} мин " +
                $"(наведение: {SeekerType}) и поражает цель \"{TargetType}\" " +
                $"(БЧ {WarheadWeight} кг).");
        }
    }
}

