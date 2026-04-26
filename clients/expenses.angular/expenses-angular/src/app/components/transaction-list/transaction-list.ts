import { Component, OnInit, signal, computed } from '@angular/core';
import { Transaction } from '../../models/transaction';
import { CurrencyPipe, DatePipe, NgClass } from '@angular/common';
import { TransactionService } from '../../services/transaction.service';

@Component({
  selector: 'app-transaction-list',
  imports: [DatePipe, CurrencyPipe, NgClass],
  templateUrl: './transaction-list.html',
  styleUrl: './transaction-list.css',
})
export class TransactionListComponent implements OnInit {
  transactions = signal<Transaction[]>([]);
  constructor(private transactionService: TransactionService) {}
  ngOnInit(): void {
    console.log('in');
    this.loadTransactions();
    console.log('out');
  }

  loadTransactions(): void {
    this.transactionService.getAll().subscribe((data) => {
      this.transactions.set(data);
    });
  }

  totalIncome = computed<number>(() =>
    this.transactions()
      .filter((t) => t.type === 'Income')
      .reduce((sum, t) => sum + t.amount, 0),
  );

  totalExpenses = computed<number>(() =>
    this.transactions()
      .filter((t) => t.type === 'Expense')
      .reduce((sum, t) => sum + t.amount, 0),
  );
  netBalance = computed<number>(() => this.totalIncome() - this.totalExpenses());
}
