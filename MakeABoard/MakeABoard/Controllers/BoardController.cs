using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MakeABoard.Models;


namespace MakeABoard.Models
{
    public class BoardController : Controller
    {
        // GET: GameBoard
        public ActionResult BoardDetail()
        {
            int[,] ControllerGameBoard = new int[3, 3]
            {
                { 0,0,0 }, {1,1,1 }, {-1,-1,-1 }
            };
            BoardModel boardModel = new BoardModel();

            return View("Board", boardModel);
            // MakeABoard.Models.BoardModel
        }
        public ActionResult Cell00(int move) {
            int[,] ControllerGameBoard = new int[3, 3]
                {
                    { 0,0,0 }, {1,1,1 }, {-1,-1,-1 }
                };
            //            Player player = new Player(ControllerGameBoard.ga);

//            return View("Board", player.Move());
            return View("Board");
        }
        // GET: BoardController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BoardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
