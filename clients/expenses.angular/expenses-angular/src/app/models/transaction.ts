export interface Transaction {
    type: string,
    amount: number,
    category: string,
    id: number,
    createdAt: Date,
    updatedAt: Date
}
