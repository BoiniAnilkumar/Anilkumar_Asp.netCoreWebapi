using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLib.Services.Service_Implementation
{
    public class MasterService : IMasterService
    {
        private readonly IMasterRepository _repository;
        public MasterService(IMasterRepository repository)
        {
            _repository = repository;
        }
        // ===================== GENDERS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetGendersAsync()
        {
            var data = await _repository.GetGendersAsync();

            var result = data.Select(g => new DropdownDTO
            {
                Id = g.GenderId,
                Name = g.GenderName
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        // ===================== DEPARTMENTS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetDepartmentsAsync(int clientId)
        {
            var data = await _repository.GetDepartmentsAsync(clientId);

            var result = data.Select(d => new DropdownDTO
            {
                Id = d.DepartmentId,
                Name = d.DepartmentName
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        // ===================== SECTIONS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetSectionsAsync(int departmentId)
        {
            var data = await _repository.GetSectionsAsync(departmentId);

            var result = data.Select(s => new DropdownDTO
            {
                Id = s.SectionId,
                Name = s.SectionName
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        // ===================== DESIGNATIONS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetDesignationsAsync()
        {
            var data = await _repository.GetDesignationsAsync();

            var result = data.Select(d => new DropdownDTO
            {
                Id = d.DesignationId,
                Name = d.DesignationName
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        // ===================== LOCATIONS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetLocationsAsync()
        {
            var data = await _repository.GetLocationsAsync();

            var result = data.Select(l => new DropdownDTO
            {
                Id = l.LocationId,
                Name = l.LocationName
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        //===================== EMP TYPES =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetEmpTypesAsync()
        {
            var data = await _repository.GetEmpTypesAsync();

            var result = data.Select(e => new DropdownDTO
            {
                Id = e.EmployeeId,
                Name = e.EmployeeName ?? string.Empty
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }

        //-----------------REportingEmployees-----------------
        public async Task<ApiResponse<List<DropdownDTO>>> GetReportingEmployeesAsync(int clientId)
        {
            var data = await _repository.GetReportingEmployeesAsync(clientId);
            var result = data.Select(e => new DropdownDTO
            {
                Id = e.EmployeeId,
                Name = e.EmployeeName ?? string.Empty
            }).ToList();
            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }


        //===================== HOD LEVELS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetHodLevelsAsync()
        {
            var data = await _repository.GetHodLevelsAsync();

            var result = data.Select(h => new DropdownDTO
            {
                Id = h.Id,
                Name = h.HodLevel ?? string.Empty
            }).ToList();

            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }
        //===================== CLIENTS =====================
        public async Task<ApiResponse<List<DropdownDTO>>> GetClientAsync()
        {
            var data = await _repository.GetClientAsync();
            var result = data.Select(c => new DropdownDTO
            {
                Id = c.ClientId,
                Name = c.ClientName ?? string.Empty
            }).ToList();
            return ApiResponse<List<DropdownDTO>>.SuccessResponse(result);
        }
    }
}
