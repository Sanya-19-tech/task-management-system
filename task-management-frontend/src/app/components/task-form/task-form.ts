import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { TaskService } from '../../services/task.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './task-form.html',
  styleUrl: './task-form.css'
})
export class TaskForm implements OnInit {

  task: any = {
    id: 0,
    title: '',
    description: '',
    isCompleted: false
  };

  isEdit = false;

  constructor(private taskService: TaskService) {}

  ngOnInit() {
    const savedTask = localStorage.getItem("editTask");

    if (savedTask) {
      this.task = JSON.parse(savedTask);
      this.isEdit = true;
      localStorage.removeItem("editTask");
    }
  }

  addTask() {

    if (this.isEdit) {
      this.taskService.updateTask(this.task.id, this.task).subscribe(() => {
        alert("Task Updated");
        window.location.href = "/";
      });
    }
    else {
      this.taskService.createTask(this.task).subscribe(() => {
        alert("Task Added");
        window.location.href = "/";
      });
    }
  }
}