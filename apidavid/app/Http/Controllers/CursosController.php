<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Curso;
use App\Utilizador;
use App\Disciplina;
use App\Documento;
use App\Evento;

class CursosController extends Controller
{
    function index() {
      $courses = Curso::all();
      return json_encode($courses);
    }

    function show($id) {
      $course = Curso::find($id);
      return json_encode($course);
    }
}
