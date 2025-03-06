﻿using FacultyManagementSystemAPI.Models.DTOs.Enrollment;

namespace FacultyManagementSystemAPI.Services.Interfaces
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<EnrollmentDto>> GetAllIncludeStudentNameCourseNameAsync();
        Task<EnrollmentDto> GetByIdIncludeStudentNameCourseNameAsync(int id);
        Task<IEnumerable<EnrollmentDto>> GetBySemesterAsync(string name);
        Task<IEnumerable<EnrollmentDto>> GetByStudentIdAsync(int studentId);
        Task<IEnumerable<EnrollmentDto>> GetByCourseIdAsync(int courseId);
        Task DeleteAsync(int id);

        Task<int> GetEnrollmentCountAsync();
        Task<int> GetCanceledEnrollmentCountAsync();

        Task UpdateStudentGradeAsync(int studentId, int courseId, decimal newGrade);
        Task UpdateStudentExam1GradeAsync(int studentId, int courseId, decimal newGrade);
        Task UpdateStudentExam2GradeAsync(int studentId, int courseId, decimal newGrade);
    }
}