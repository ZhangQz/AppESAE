<?php

use Illuminate\Http\Request;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::get('utilizadores/curso/{id}', 'UtilizadoresController@listByCourse');
Route::get('disciplinas/curso/{id}', 'DisciplinasController@listByCourse');
Route::get('documentos/curso/{id}', 'DocumentosController@listByCourse');
Route::get('eventos/curso/{id}', 'EventosController@listByCourse');
Route::get('propinas/curso/{id}', 'PropinasController@listByCourse');
Route::get('eventos/disciplina/{id}', 'EventosController@listByDisci');

Route::resource('utilizadores', 'UtilizadoresController');
Route::resource('cursos', 'CursosController');
Route::resource('disciplinas', 'DisciplinasController');
Route::resource('documentos', 'DocumentosController');
Route::resource('eventos', 'EventosController');
Route::resource('propinas', 'PropinasController');
Route::resource('users', 'UsersController');
