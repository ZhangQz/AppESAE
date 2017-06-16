<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UsersController extends Controller
{
  function index() {
    $users = User::all();
    return json_encode($users);
  }

  function show($id) {
    $users = User::find($id);
    return json_encode($users);
  }
}
