<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Curso1;
use App\Utilizador1;
use App\Disciplina1;
use App\Documento1;
use App\Evento1;
use App\User1;

class HomeController extends Controller
{
    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Show the application dashboard.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('home');
    }
}
