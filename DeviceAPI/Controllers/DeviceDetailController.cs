using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeviceAPI.Models;

namespace DeviceAPI.Controllers
{
    // Controller with CRUD actions for DeviceDetails db table
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceDetailController : ControllerBase
    {
        private readonly DeviceUserContext _context;

        //use DeviceUserContext class
        public DeviceDetailController(DeviceUserContext context)
        {
            _context = context;
        }

        // GET: api/DeviceDetail    Read All Devices in db
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceDetail>>> GetDeviceDetails()
        {
            return await _context.DeviceDetails.ToListAsync();
        }

        // GET: api/DeviceDetail/5  Read specific device from db
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceDetail>> GetDeviceDetail(int id)
        {
            var deviceDetail = await _context.DeviceDetails.FindAsync(id);

            if (deviceDetail == null)
            {
                return NotFound();
            }

            return deviceDetail;
        }

        // PUT: api/DeviceDetail/5  Update specific device details in db
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceDetail(int id, DeviceDetail deviceDetail)
        {
            if (id != deviceDetail.DeviceDetailID)
            {
                return BadRequest();
            }

            _context.Entry(deviceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DeviceDetail   Create device in db
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeviceDetail>> PostDeviceDetail(DeviceDetail deviceDetail)
        {
            _context.DeviceDetails.Add(deviceDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeviceDetail", new { id = deviceDetail.DeviceDetailID }, deviceDetail);
        }

        // DELETE: api/DeviceDetail/5   Delete device from db
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeviceDetail(int id)
        {
            var deviceDetail = await _context.DeviceDetails.FindAsync(id);
            if (deviceDetail == null)
            {
                return NotFound();
            }

            _context.DeviceDetails.Remove(deviceDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeviceDetailExists(int id)
        {
            return _context.DeviceDetails.Any(e => e.DeviceDetailID == id);
        }
    }
}
