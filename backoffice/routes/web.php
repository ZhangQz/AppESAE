<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

/*Route::get('/', function () {
    return view('welcome');
});*/

/* Código antigo...
Route::get('home', ['as' => 'home',
		    		'uses' => 'VeiculoController@home'
		   		   ]);
*/

Route::get('/', 'PageController@index')->name('index');
Route::get('creditos', 'PageController@credito')->name('creditos');

Route::resource("cliente", 'ClienteController1');
Route::resource("maquina", 'MaquinaController1');
Route::resource("plano", 'PlanoController1');
Route::resource("clienteusaplano", 'ClienteusaplanoController1');
Route::resource("curso", 'CursoController1');
Route::resource("disciplina", 'DisciplinaController1');
Route::resource("documento", 'DocumentoController1');
Route::resource("evento", 'EventoController1');
Route::resource("propina", 'PropinaController1');
Route::resource("utilizador", 'UtilizadorController1');
Route::resource("user", 'UsersController1');

Auth::routes();

Route::get('/index', 'HomeController@index');
