using System;
using GPACalculator.Commons;
using GPACalculator.Data.Repositories.File.Implementation;
using GPACalculator.Data.Repositories.File.Interface;
using GPACalculator.Data.Repositories.Implementations.InMemory;
using GPACalculator.Data.Repositories.Interface.InMemory;
using GPACalculator.Services.Implementation;
using GPACalculator.Services.Interface;

namespace GPACalculator.Services
{
    public static class GlobalConfig
    {
        public static ICalculatorService _calculatorService;
        public static IInMemoryRepository _inMemoryRepository;
        public static IFileRepository _fileRepository { get; set; }

        public static string _path = Utilities.GetApsolutePath(@"Courses.txt");


        public static void Instantiate()
        {
            _inMemoryRepository = new InMemoryRepository();
            _fileRepository = new FileRepository(_path);

            //------------------- Services taking injections ---------------------

            _calculatorService = new CalculatorService(_inMemoryRepository, _fileRepository);
        }
    }
}
