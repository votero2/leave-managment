﻿using leave_managment.Contracts;
using leave_managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindByID(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            //var leaveType = _db.LeaveTypes.FirstOrDefault(x => x.Id == id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
           return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
             _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
