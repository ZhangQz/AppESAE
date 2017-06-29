<?php

namespace App\Http\Controllers;

class PageController extends Controller
{
    public function index() {
    	return view('index');
    }

    /* Método redundante...
        public function home() {
        	return view('index');
        }
    */
    public function curso() {
      return view('curso.index');
    }

    public function disciplina() {
      return view('disciplina.index');
    }

    public function documento() {
      return view('documento.index');
    }

    public function evento() {
      return view('evento.index');
    }

    public function propina() {
      return view('propina.index');
    }

    public function utilizadores() {
      return view('utilizador.index');
    }

    public function user() {
      return view('user.index');
    }

    public function credito() {
    	return view('pages.creditos');
    }
}
