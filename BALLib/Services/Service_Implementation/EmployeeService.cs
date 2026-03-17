//using BALLib.DTOs.EmployeeDTO;
//using BALLib.Services.Service_Interface;
//using CommonlibDAO.Modles.MasterTables;
//using CommonlibDAO.Repositories.Interface;

//namespace BALLib.Services.Service_Implementation
//{
//    public class EmployeeService : IEmployeeService
//    {
//        private readonly IEmployeeRepository _repository;

//        public EmployeeService(IEmployeeRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<EmployeeDTO> CreateAsync(CreateEmployeeDTO dto)
//        {
//            // DTO → Entity
//            var entity = new tbl_Employee
//            {
//                EmployeeName = dto.Name,
//                EmailId = dto.Email
//            };

//            await _repository.AddAsync(entity);
//            await _repository.SaveAsync();

//            // Entity → DTO
//            return new EmployeeDTO
//            {
//                Id = entity.EmployeeId,
//                Name   = entity.EmployeeName,
//                Email = entity.EmailId 
//            };
//        }

//        public async Task<List<EmployeeDTO>> GetAllAsync()
//        {
//            var list = await _repository.GetAllAsync();

//            return list.Select(x => new EmployeeDTO
//            {
//                Id = x.EmployeeId,
//                Name = x.EmployeeName,
//                Email = x.EmailId
//            }).ToList();
//        }
//    }
//}
